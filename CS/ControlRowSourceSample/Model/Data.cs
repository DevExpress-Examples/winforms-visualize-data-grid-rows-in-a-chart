using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControlRowSourceSample.Model {
    public class SaleItem {
        public string State { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public int UnitsSold { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DataType(DataType.Currency)]
        public decimal Revenue { get; set; }
        public int UnitsSoldTarget { get; set; }
        [DataType(DataType.Currency)]
        public decimal RevenueTarget { get; set; }
        [DisplayFormat(DataFormatString = "p")]
        public float SalesDynamic { get { return (float)((Revenue - RevenueTarget) / Revenue); } }
        public DateTime ReportDate { get; set; }
    }

    public static class SalesProductDataGenerator {
        static Random rnd = new Random();

        public static List<SaleItem> GetData() {
            DataSet dataSet = LoadData("DashboardSales");

            DataTable productsTable = dataSet.Tables["Products"];
            DataTable categoriesTable = dataSet.Tables["Categories"];
            DataTable regionsTable = dataSet.Tables["Regions"];


            IEnumerable<ProductItemBase> products = productsTable.AsEnumerable().Join(
                    categoriesTable.AsEnumerable(),
                    p => p["CategoryID"],
                    c => c["CategoryID"],
                    (p, c) => new ProductItemBase() {
                        Price = p.Field<decimal>("ListPrice"),
                        Product = p.Field<string>("Name"),
                        Category = c.Field<string>("CategoryName"),
                    }
            );

            var bikes = products.Where(p => p.Category == "Bikes");

            return GenerateData(regionsTable.Rows, products);

        }

        static List<SaleItem> GenerateData(DataRowCollection regions, IEnumerable<ProductItemBase> products) {
            List<SaleItem> totalSales = new List<SaleItem>();
            foreach(DataRow region in regions) {
                string state = region.Field<string>("Region");
                int year = DateTime.Today.Year - 1;
                for(int month = 1; month <= 12; month++) {
                    foreach(ProductItemBase product in products) {
                        SaleItem tsItem = new SaleItem { State = state, Category = product.Category, Product = product.Product, Price = product.Price };
                        DateTime dt = new DateTime(year, month, 1);
                        int uSold = GetUnitsSold(product.Category);
                        int uSoldTarget = uSold + rnd.Next(-(int)(uSold * 0.2), (int)(uSold * 0.2));
                        decimal rev = uSold * product.Price;
                        decimal revTarget = uSoldTarget * product.Price;

                        tsItem.Revenue = rev;
                        tsItem.RevenueTarget = revTarget;
                        tsItem.UnitsSold = uSold;
                        tsItem.UnitsSoldTarget = uSoldTarget;
                        tsItem.ReportDate = dt;

                        totalSales.Add(tsItem);
                    }
                }
            }
            return totalSales;
        }
        static int GetUnitsSold(string category) {
            int max = category.Equals("Bikes") ? 50 : 250;
            return rnd.Next(1, max);
        }
        static DataSet LoadData(string fileName) {
            string path = string.Format("../../Data/{0}.xml", fileName);
            DataSet ds = new DataSet();
            ds.ReadXml(path, XmlReadMode.ReadSchema);
            return ds;
        }

        class ProductItemBase {
            public string Product { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }
        }
    }
}
