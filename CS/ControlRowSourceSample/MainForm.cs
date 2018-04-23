using ControlRowSourceSample.Model;
using System;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Controls;
using DevExpress.XtraCharts;

namespace ControlRowSourceSample {
    public partial class MainForm : DevExpress.XtraEditors.XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            pLinqServerModeSource.Source = SalesProductDataGenerator.GetData();

            #region #ControlRowSource
            // Assign a new instance of ControlRowSource to the chart's DataSource property.
            chartControl.DataSource = new ControlRowSource() {
                Control = mainView,
                ControlRows = ControlRows.Selected
            };
            // Specify chart properties that configures series to display.
            chartControl.SeriesDataMember = "State";

            SeriesBase seriesTemplate = chartControl.SeriesTemplate;
            seriesTemplate.ArgumentDataMember = "Category";
            seriesTemplate.ValueDataMembers.AddRange("Revenue");
            // Configure additional chart properties.
            seriesTemplate.CrosshairLabelPattern = "{S}: {V:C2}";
            seriesTemplate.SeriesPointsSorting = SortingMode.Descending;
            seriesTemplate.SeriesPointsSortingKey = SeriesPointKey.Value_1;
            seriesTemplate.SummaryFunction = "SUM([Revenue])";

            XYDiagram diagram = (XYDiagram)chartControl.Diagram;
            diagram.AxisY.Label.TextPattern = "{V:C0}";

            chartControl.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Right;
            chartControl.Legend.AlignmentVertical = LegendAlignmentVertical.Top;
            #endregion #ControlRowSource
        }

        void OnGridViewRowCellStyle(object sender, RowCellStyleEventArgs e) {
            if(e.Column.FieldName == "SalesDynamic")
                e.Appearance.ForeColor = Convert.ToDouble(e.CellValue) < 0 ? Color.Red : Color.Green;
        }
    }
}
