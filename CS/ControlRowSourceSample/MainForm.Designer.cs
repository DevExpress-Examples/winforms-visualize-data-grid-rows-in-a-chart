namespace ControlRowSourceSample {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.pLinqServerModeSource = new DevExpress.Data.PLinq.PLinqServerModeSource();
            this.mainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsSold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevenue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsSoldTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevenueTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesDynamic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReportDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLinqServerModeSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.pLinqServerModeSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.mainView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(766, 688);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mainView});
            // 
            // pLinqServerModeSource
            // 
            this.pLinqServerModeSource.ElementType = typeof(ControlRowSourceSample.Model.SaleItem);
            // 
            // mainView
            // 
            this.mainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colState,
            this.colProduct,
            this.colCategory,
            this.colUnitsSold,
            this.colPrice,
            this.colRevenue,
            this.colUnitsSoldTarget,
            this.colRevenueTarget,
            this.colSalesDynamic,
            this.colReportDate});
            this.mainView.GridControl = this.gridControl;
            this.mainView.GroupCount = 2;
            this.mainView.Name = "mainView";
            this.mainView.OptionsBehavior.Editable = false;
            this.mainView.OptionsSelection.MultiSelect = true;
            this.mainView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colState, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCategory, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProduct, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colReportDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.mainView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.OnGridViewRowCellStyle);
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 0;
            // 
            // colProduct
            // 
            this.colProduct.FieldName = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.Visible = true;
            this.colProduct.VisibleIndex = 0;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 0;
            // 
            // colUnitsSold
            // 
            this.colUnitsSold.FieldName = "UnitsSold";
            this.colUnitsSold.Name = "colUnitsSold";
            this.colUnitsSold.Visible = true;
            this.colUnitsSold.VisibleIndex = 1;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            // 
            // colRevenue
            // 
            this.colRevenue.FieldName = "Revenue";
            this.colRevenue.Name = "colRevenue";
            this.colRevenue.Visible = true;
            this.colRevenue.VisibleIndex = 3;
            // 
            // colUnitsSoldTarget
            // 
            this.colUnitsSoldTarget.FieldName = "UnitsSoldTarget";
            this.colUnitsSoldTarget.Name = "colUnitsSoldTarget";
            this.colUnitsSoldTarget.Visible = true;
            this.colUnitsSoldTarget.VisibleIndex = 4;
            // 
            // colRevenueTarget
            // 
            this.colRevenueTarget.FieldName = "RevenueTarget";
            this.colRevenueTarget.Name = "colRevenueTarget";
            this.colRevenueTarget.Visible = true;
            this.colRevenueTarget.VisibleIndex = 5;
            // 
            // colSalesDynamic
            // 
            this.colSalesDynamic.FieldName = "SalesDynamic";
            this.colSalesDynamic.Name = "colSalesDynamic";
            this.colSalesDynamic.OptionsColumn.ReadOnly = true;
            this.colSalesDynamic.Visible = true;
            this.colSalesDynamic.VisibleIndex = 6;
            // 
            // colReportDate
            // 
            this.colReportDate.FieldName = "ReportDate";
            this.colReportDate.Name = "colReportDate";
            this.colReportDate.Visible = true;
            this.colReportDate.VisibleIndex = 7;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterControl1.Location = new System.Drawing.Point(766, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(12, 688);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // chartControl
            // 
            this.chartControl.DataBindings = null;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Location = new System.Drawing.Point(778, 0);
            this.chartControl.Name = "chartControl";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl.Size = new System.Drawing.Size(500, 688);
            this.chartControl.TabIndex = 2;
            chartTitle1.Text = "Total Revenue";
            this.chartControl.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 688);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.chartControl);
            this.Name = "MainForm";
            this.Text = "ControlRowSource Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLinqServerModeSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView mainView;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.Data.PLinq.PLinqServerModeSource pLinqServerModeSource;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsSold;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colRevenue;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsSoldTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colRevenueTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesDynamic;
        private DevExpress.XtraGrid.Columns.GridColumn colReportDate;
        private DevExpress.XtraCharts.ChartControl chartControl;
    }
}

