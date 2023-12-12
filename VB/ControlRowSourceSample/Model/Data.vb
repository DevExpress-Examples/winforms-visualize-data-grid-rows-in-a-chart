Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.ComponentModel.DataAnnotations

Namespace ControlRowSourceSample.Model

    Public Class SaleItem

        Public Property State As String

        Public Property Product As String

        Public Property Category As String

        Public Property UnitsSold As Integer

        <System.ComponentModel.DataAnnotations.DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.Currency)>
        Public Property Price As Decimal

        <System.ComponentModel.DataAnnotations.DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.Currency)>
        Public Property Revenue As Decimal

        Public Property UnitsSoldTarget As Integer

        <System.ComponentModel.DataAnnotations.DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.Currency)>
        Public Property RevenueTarget As Decimal

        <System.ComponentModel.DataAnnotations.DisplayFormatAttribute(DataFormatString:="p")>
        Public ReadOnly Property SalesDynamic As Single
            Get
                Return CSng(((Me.Revenue - Me.RevenueTarget) / Me.Revenue))
            End Get
        End Property

        Public Property ReportDate As DateTime
    End Class

    Public Module SalesProductDataGenerator

        Private rnd As System.Random = New System.Random()

        Public Function GetData() As List(Of ControlRowSourceSample.Model.SaleItem)
            Dim dataSet As System.Data.DataSet = ControlRowSourceSample.Model.SalesProductDataGenerator.LoadData("DashboardSales")
            Dim productsTable As System.Data.DataTable = dataSet.Tables("Products")
            Dim categoriesTable As System.Data.DataTable = dataSet.Tables("Categories")
            Dim regionsTable As System.Data.DataTable = dataSet.Tables("Regions")
            Dim products As System.Collections.Generic.IEnumerable(Of ControlRowSourceSample.Model.SalesProductDataGenerator.ProductItemBase) = productsTable.AsEnumerable().Join(categoriesTable.AsEnumerable(), Function(p) p("CategoryID"), Function(c) c("CategoryID"), Function(p, c) New ControlRowSourceSample.Model.SalesProductDataGenerator.ProductItemBase() With {.Price = p.Field(Of Decimal)("ListPrice"), .Product = p.Field(Of String)("Name"), .Category = c.Field(Of String)("CategoryName")})
            Dim bikes = products.Where(Function(p) Equals(p.Category, "Bikes"))
            Return ControlRowSourceSample.Model.SalesProductDataGenerator.GenerateData(regionsTable.Rows, products)
        End Function

        Private Function GenerateData(ByVal regions As System.Data.DataRowCollection, ByVal products As System.Collections.Generic.IEnumerable(Of ControlRowSourceSample.Model.SalesProductDataGenerator.ProductItemBase)) As List(Of ControlRowSourceSample.Model.SaleItem)
            Dim totalSales As System.Collections.Generic.List(Of ControlRowSourceSample.Model.SaleItem) = New System.Collections.Generic.List(Of ControlRowSourceSample.Model.SaleItem)()
            For Each region As System.Data.DataRow In regions
                Dim state As String = region.Field(Of String)("Region")
                Dim year As Integer = System.DateTime.Today.Year - 1
                For month As Integer = 1 To 12
                    For Each product As ControlRowSourceSample.Model.SalesProductDataGenerator.ProductItemBase In products
                        Dim tsItem As ControlRowSourceSample.Model.SaleItem = New ControlRowSourceSample.Model.SaleItem With {.State = state, .Category = product.Category, .Product = product.Product, .Price = product.Price}
                        Dim dt As System.DateTime = New System.DateTime(year, month, 1)
                        Dim uSold As Integer = ControlRowSourceSample.Model.SalesProductDataGenerator.GetUnitsSold(product.Category)
                        Dim uSoldTarget As Integer = uSold + ControlRowSourceSample.Model.SalesProductDataGenerator.rnd.[Next](-CInt((uSold * 0.2)), CInt((uSold * 0.2)))
                        Dim rev As Decimal = uSold * product.Price
                        Dim revTarget As Decimal = uSoldTarget * product.Price
                        tsItem.Revenue = rev
                        tsItem.RevenueTarget = revTarget
                        tsItem.UnitsSold = uSold
                        tsItem.UnitsSoldTarget = uSoldTarget
                        tsItem.ReportDate = dt
                        totalSales.Add(tsItem)
                    Next
                Next
            Next

            Return totalSales
        End Function

        Private Function GetUnitsSold(ByVal category As String) As Integer
            Dim max As Integer = If(category.Equals("Bikes"), 50, 250)
            Return ControlRowSourceSample.Model.SalesProductDataGenerator.rnd.[Next](1, max)
        End Function

        Private Function LoadData(ByVal fileName As String) As DataSet
            Dim path As String = String.Format("../../Data/{0}.xml", fileName)
            Dim ds As System.Data.DataSet = New System.Data.DataSet()
            ds.ReadXml(path, System.Data.XmlReadMode.ReadSchema)
            Return ds
        End Function

        Private Class ProductItemBase

            Public Property Product As String

            Public Property Category As String

            Public Property Price As Decimal
        End Class
    End Module
End Namespace
