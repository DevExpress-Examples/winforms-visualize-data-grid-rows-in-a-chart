Imports ControlRowSourceSample.Model
Imports System
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data.Controls
Imports DevExpress.XtraCharts

Namespace ControlRowSourceSample
    Partial Public Class MainForm
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            pLinqServerModeSource.Source = SalesProductDataGenerator.GetData()

'            #Region "#ControlRowSource"
            ' Assign a new instance of ControlRowSource to the chart's DataSource property.
            chartControl.DataSource = New ControlRowSource() With { _
                .Control = mainView, _
                .ControlRows = ControlRows.Selected _
            }
            ' Specify chart properties that configures series to display.
            chartControl.SeriesDataMember = "State"

            Dim seriesTemplate As SeriesBase = chartControl.SeriesTemplate
            seriesTemplate.ArgumentDataMember = "Category"
            seriesTemplate.ValueDataMembers.AddRange("Revenue")
            ' Configure additional chart properties.
            seriesTemplate.CrosshairLabelPattern = "{S}: {V:C2}"
            seriesTemplate.SeriesPointsSorting = SortingMode.Descending
            seriesTemplate.SeriesPointsSortingKey = SeriesPointKey.Value_1
            seriesTemplate.SummaryFunction = "SUM([Revenue])"

            Dim diagram As XYDiagram = CType(chartControl.Diagram, XYDiagram)
            diagram.AxisY.Label.TextPattern = "{V:C0}"

            chartControl.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Right
            chartControl.Legend.AlignmentVertical = LegendAlignmentVertical.Top
'            #End Region ' #ControlRowSource
        End Sub

        Private Sub OnGridViewRowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles mainView.RowCellStyle
            If e.Column.FieldName = "SalesDynamic" Then
                e.Appearance.ForeColor = If(Convert.ToDouble(e.CellValue) < 0, Color.Red, Color.Green)
            End If
        End Sub
    End Class
End Namespace
