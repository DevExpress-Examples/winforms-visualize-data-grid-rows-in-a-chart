Namespace ControlRowSourceSample
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.pLinqServerModeSource = New DevExpress.Data.PLinq.PLinqServerModeSource()
            Me.mainView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProduct = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsSold = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRevenue = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsSoldTarget = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRevenueTarget = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSalesDynamic = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReportDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
            Me.defaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pLinqServerModeSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mainView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl
            ' 
            Me.gridControl.DataSource = Me.pLinqServerModeSource
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.mainView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(766, 688)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.mainView})
            ' 
            ' pLinqServerModeSource
            ' 
            Me.pLinqServerModeSource.ElementType = GetType(ControlRowSourceSample.Model.SaleItem)
            ' 
            ' mainView
            ' 
            Me.mainView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colState, Me.colProduct, Me.colCategory, Me.colUnitsSold, Me.colPrice, Me.colRevenue, Me.colUnitsSoldTarget, Me.colRevenueTarget, Me.colSalesDynamic, Me.colReportDate})
            Me.mainView.GridControl = Me.gridControl
            Me.mainView.GroupCount = 2
            Me.mainView.Name = "mainView"
            Me.mainView.OptionsBehavior.Editable = False
            Me.mainView.OptionsSelection.MultiSelect = True
            Me.mainView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { _
                New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colState, DevExpress.Data.ColumnSortOrder.Ascending), _
                New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCategory, DevExpress.Data.ColumnSortOrder.Ascending), _
                New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colProduct, DevExpress.Data.ColumnSortOrder.Ascending), _
                New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colReportDate, DevExpress.Data.ColumnSortOrder.Ascending) _
            })
            ' 
            ' colState
            ' 
            Me.colState.FieldName = "State"
            Me.colState.Name = "colState"
            Me.colState.Visible = True
            Me.colState.VisibleIndex = 0
            ' 
            ' colProduct
            ' 
            Me.colProduct.FieldName = "Product"
            Me.colProduct.Name = "colProduct"
            Me.colProduct.Visible = True
            Me.colProduct.VisibleIndex = 0
            ' 
            ' colCategory
            ' 
            Me.colCategory.FieldName = "Category"
            Me.colCategory.Name = "colCategory"
            Me.colCategory.Visible = True
            Me.colCategory.VisibleIndex = 0
            ' 
            ' colUnitsSold
            ' 
            Me.colUnitsSold.FieldName = "UnitsSold"
            Me.colUnitsSold.Name = "colUnitsSold"
            Me.colUnitsSold.Visible = True
            Me.colUnitsSold.VisibleIndex = 1
            ' 
            ' colPrice
            ' 
            Me.colPrice.FieldName = "Price"
            Me.colPrice.Name = "colPrice"
            Me.colPrice.Visible = True
            Me.colPrice.VisibleIndex = 2
            ' 
            ' colRevenue
            ' 
            Me.colRevenue.FieldName = "Revenue"
            Me.colRevenue.Name = "colRevenue"
            Me.colRevenue.Visible = True
            Me.colRevenue.VisibleIndex = 3
            ' 
            ' colUnitsSoldTarget
            ' 
            Me.colUnitsSoldTarget.FieldName = "UnitsSoldTarget"
            Me.colUnitsSoldTarget.Name = "colUnitsSoldTarget"
            Me.colUnitsSoldTarget.Visible = True
            Me.colUnitsSoldTarget.VisibleIndex = 4
            ' 
            ' colRevenueTarget
            ' 
            Me.colRevenueTarget.FieldName = "RevenueTarget"
            Me.colRevenueTarget.Name = "colRevenueTarget"
            Me.colRevenueTarget.Visible = True
            Me.colRevenueTarget.VisibleIndex = 5
            ' 
            ' colSalesDynamic
            ' 
            Me.colSalesDynamic.FieldName = "SalesDynamic"
            Me.colSalesDynamic.Name = "colSalesDynamic"
            Me.colSalesDynamic.OptionsColumn.ReadOnly = True
            Me.colSalesDynamic.Visible = True
            Me.colSalesDynamic.VisibleIndex = 6
            ' 
            ' colReportDate
            ' 
            Me.colReportDate.FieldName = "ReportDate"
            Me.colReportDate.Name = "colReportDate"
            Me.colReportDate.Visible = True
            Me.colReportDate.VisibleIndex = 7
            ' 
            ' splitterControl1
            ' 
            Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.splitterControl1.Location = New System.Drawing.Point(766, 0)
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(12, 688)
            Me.splitterControl1.TabIndex = 1
            Me.splitterControl1.TabStop = False
            ' 
            ' defaultLookAndFeel
            ' 
            Me.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' chartControl
            ' 
            Me.chartControl.DataBindings = Nothing
            Me.chartControl.Dock = System.Windows.Forms.DockStyle.Right
            Me.chartControl.Legend.Name = "Default Legend"
            Me.chartControl.Location = New System.Drawing.Point(778, 0)
            Me.chartControl.Name = "chartControl"
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
            Me.chartControl.Size = New System.Drawing.Size(500, 688)
            Me.chartControl.TabIndex = 2
            chartTitle1.Text = "Total Revenue"
            Me.chartControl.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1278, 688)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.chartControl)
            Me.Name = "MainForm"
            Me.Text = "ControlRowSource Sample"
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pLinqServerModeSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mainView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private gridControl As DevExpress.XtraGrid.GridControl
        Private WithEvents mainView As DevExpress.XtraGrid.Views.Grid.GridView
        Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
        Private defaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private pLinqServerModeSource As DevExpress.Data.PLinq.PLinqServerModeSource
        Private colState As DevExpress.XtraGrid.Columns.GridColumn
        Private colProduct As DevExpress.XtraGrid.Columns.GridColumn
        Private colCategory As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitsSold As DevExpress.XtraGrid.Columns.GridColumn
        Private colPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private colRevenue As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitsSoldTarget As DevExpress.XtraGrid.Columns.GridColumn
        Private colRevenueTarget As DevExpress.XtraGrid.Columns.GridColumn
        Private colSalesDynamic As DevExpress.XtraGrid.Columns.GridColumn
        Private colReportDate As DevExpress.XtraGrid.Columns.GridColumn
        Private chartControl As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace

