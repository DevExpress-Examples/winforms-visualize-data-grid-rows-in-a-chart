Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.ComponentModel.DataAnnotations

Namespace ControlRowSourceSample.Model
    Public Class SaleItem
        Public Property State() As String
        Public Property Product() As String
        Public Property Category() As String
        Public Property UnitsSold() As Integer
        <DataType(DataType.Currency)> _
        Public Property Price() As Decimal
        <DataType(DataType.Currency)> _
        Public Property Revenue() As Decimal
        Public Property UnitsSoldTarget() As Integer
        <DataType(DataType.Currency)> _
        Public Property RevenueTarget() As Decimal
        <DisplayFormat(DataFormatString := "p")> _
        Public ReadOnly Property SalesDynamic() As Single
            Get
                Return CSng((Revenue - RevenueTarget) / Revenue)
            End Get
        End Property
        Public Property ReportDate() As Date
    End Class

    Public NotInheritable Class SalesProductDataGenerator

        Private Sub New()
        End Sub
        Private Shared rnd As New Random()

        Public Shared Function GetData() As List(Of SaleItem)
            Dim dataSet As DataSet = LoadData("DashboardSales")

            Dim productsTable As DataTable = dataSet.Tables("Products")
            Dim categoriesTable As DataTable = dataSet.Tables("Categories")
            Dim regionsTable As DataTable = dataSet.Tables("Regions")


            Dim products As IEnumerable(Of ProductItemBase) = productsTable.AsEnumerable().Join(categoriesTable.AsEnumerable(), Function(p) p("CategoryID"), Function(c) c("CategoryID"), Function(p, c) New ProductItemBase() With { _
                .Price = p.Field(Of Decimal)("ListPrice"), _
                .Product = p.Field(Of String)("Name"), _
                .Category = c.Field(Of String)("CategoryName") _
            })

            Dim bikes = products.Where(Function(p) p.Category = "Bikes")

            Return GenerateData(regionsTable.Rows, products)

        End Function

        Private Shared Function GenerateData(ByVal regions As DataRowCollection, ByVal products As IEnumerable(Of ProductItemBase)) As List(Of SaleItem)
            Dim totalSales As New List(Of SaleItem)()
            For Each region As DataRow In regions
                Dim state As String = region.Field(Of String)("Region")
                Dim year As Integer = Date.Today.Year - 1
                For month As Integer = 1 To 12
                    For Each product As ProductItemBase In products
                        Dim tsItem As SaleItem = New SaleItem With { _
                            .State = state, _
                            .Category = product.Category, _
                            .Product = product.Product, _
                            .Price = product.Price _
                        }
                        Dim dt As New Date(year, month, 1)
                        Dim uSold As Integer = GetUnitsSold(product.Category)
                        Dim uSoldTarget As Integer = uSold + rnd.Next(-CInt((uSold * 0.2)), CInt((uSold * 0.2)))
                        Dim rev As Decimal = uSold * product.Price
                        Dim revTarget As Decimal = uSoldTarget * product.Price

                        tsItem.Revenue = rev
                        tsItem.RevenueTarget = revTarget
                        tsItem.UnitsSold = uSold
                        tsItem.UnitsSoldTarget = uSoldTarget
                        tsItem.ReportDate = dt

                        totalSales.Add(tsItem)
                    Next product
                Next month
            Next region
            Return totalSales
        End Function
        Private Shared Function GetUnitsSold(ByVal category As String) As Integer
            Dim max As Integer = If(category.Equals("Bikes"), 50, 250)
            Return rnd.Next(1, max)
        End Function
        Private Shared Function LoadData(ByVal fileName As String) As DataSet
            Dim path As String = String.Format("../../Data/{0}.xml", fileName)
            Dim ds As New DataSet()
            ds.ReadXml(path, XmlReadMode.ReadSchema)
            Return ds
        End Function

        Private Class ProductItemBase
            Public Property Product() As String
            Public Property Category() As String
            Public Property Price() As Decimal
        End Class
    End Class
End Namespace
