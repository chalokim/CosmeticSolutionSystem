
namespace CosmeticSolutionSystem
{
    partial class ChildFormIncomeStatement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView5 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView6 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.financialStatementModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col매출액 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col매출원가 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col매출총이익 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col판매비와관리비 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col영업이익 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col영업외손익 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col당기순이익 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IncomeChart = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.financialStatementModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).BeginInit();
            this.SuspendLayout();
            // 
            // financialStatementModelBindingSource
            // 
            this.financialStatementModelBindingSource.DataSource = typeof(CosmeticSolutionSystem.Data.Models.FinancialStatementModel);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.financialStatementModelBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 420);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Padding = new System.Windows.Forms.Padding(3);
            this.gridControl1.Size = new System.Drawing.Size(1148, 230);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYear,
            this.col매출액,
            this.col매출원가,
            this.col매출총이익,
            this.col판매비와관리비,
            this.col영업이익,
            this.col영업외손익,
            this.col당기순이익});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colYear
            // 
            this.colYear.FieldName = "Year";
            this.colYear.MinWidth = 25;
            this.colYear.Name = "colYear";
            this.colYear.OptionsColumn.ReadOnly = true;
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 0;
            this.colYear.Width = 94;
            // 
            // col매출액
            // 
            this.col매출액.FieldName = "매출액";
            this.col매출액.MinWidth = 25;
            this.col매출액.Name = "col매출액";
            this.col매출액.OptionsColumn.ReadOnly = true;
            this.col매출액.Visible = true;
            this.col매출액.VisibleIndex = 1;
            this.col매출액.Width = 94;
            // 
            // col매출원가
            // 
            this.col매출원가.FieldName = "매출원가";
            this.col매출원가.MinWidth = 25;
            this.col매출원가.Name = "col매출원가";
            this.col매출원가.Visible = true;
            this.col매출원가.VisibleIndex = 2;
            this.col매출원가.Width = 94;
            // 
            // col매출총이익
            // 
            this.col매출총이익.FieldName = "매출총이익";
            this.col매출총이익.MinWidth = 25;
            this.col매출총이익.Name = "col매출총이익";
            this.col매출총이익.Visible = true;
            this.col매출총이익.VisibleIndex = 3;
            this.col매출총이익.Width = 94;
            // 
            // col판매비와관리비
            // 
            this.col판매비와관리비.FieldName = "판매비와관리비";
            this.col판매비와관리비.MinWidth = 25;
            this.col판매비와관리비.Name = "col판매비와관리비";
            this.col판매비와관리비.Visible = true;
            this.col판매비와관리비.VisibleIndex = 4;
            this.col판매비와관리비.Width = 94;
            // 
            // col영업이익
            // 
            this.col영업이익.FieldName = "영업이익";
            this.col영업이익.MinWidth = 25;
            this.col영업이익.Name = "col영업이익";
            this.col영업이익.Visible = true;
            this.col영업이익.VisibleIndex = 5;
            this.col영업이익.Width = 94;
            // 
            // col영업외손익
            // 
            this.col영업외손익.FieldName = "영업외손익";
            this.col영업외손익.MinWidth = 25;
            this.col영업외손익.Name = "col영업외손익";
            this.col영업외손익.Visible = true;
            this.col영업외손익.VisibleIndex = 6;
            this.col영업외손익.Width = 94;
            // 
            // col당기순이익
            // 
            this.col당기순이익.FieldName = "당기순이익";
            this.col당기순이익.MinWidth = 25;
            this.col당기순이익.Name = "col당기순이익";
            this.col당기순이익.Visible = true;
            this.col당기순이익.VisibleIndex = 7;
            this.col당기순이익.Width = 94;
            // 
            // IncomeChart
            // 
            this.IncomeChart.DataSource = this.financialStatementModelBindingSource;
            xyDiagram2.AxisX.NumericScaleOptions.AutoGrid = false;
            xyDiagram2.AxisX.Title.Font = new System.Drawing.Font("Tahoma", 10F);
            xyDiagram2.AxisX.Title.Text = "년도";
            xyDiagram2.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisX.VisualRange.Auto = false;
            xyDiagram2.AxisX.VisualRange.AutoSideMargins = false;
            xyDiagram2.AxisX.VisualRange.EndSideMargin = 0.6D;
            xyDiagram2.AxisX.VisualRange.MaxValueSerializable = "9";
            xyDiagram2.AxisX.VisualRange.MinValueSerializable = "0";
            xyDiagram2.AxisX.VisualRange.StartSideMargin = 0.6D;
            xyDiagram2.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram2.AxisX.WholeRange.EndSideMargin = 0.6D;
            xyDiagram2.AxisX.WholeRange.StartSideMargin = 0.6D;
            xyDiagram2.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 10F);
            xyDiagram2.AxisY.Title.Text = "금액(단위: 만 원)";
            xyDiagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.IncomeChart.Diagram = xyDiagram2;
            this.IncomeChart.Legend.Name = "Default Legend";
            this.IncomeChart.Location = new System.Drawing.Point(12, 12);
            this.IncomeChart.Name = "IncomeChart";
            series4.ArgumentDataMember = "Year";
            series4.Name = "매출액";
            series4.ValueDataMembersSerializable = "매출액";
            series4.View = lineSeriesView4;
            series5.ArgumentDataMember = "Year";
            series5.Name = "영업이익";
            series5.ValueDataMembersSerializable = "영업이익";
            series5.View = lineSeriesView5;
            series6.ArgumentDataMember = "Year";
            series6.Name = "당기순이익";
            series6.ValueDataMembersSerializable = "당기순이익";
            series6.View = lineSeriesView6;
            this.IncomeChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4,
        series5,
        series6};
            this.IncomeChart.Size = new System.Drawing.Size(1148, 396);
            this.IncomeChart.TabIndex = 4;
            chartTitle2.Text = "2016년~2020년 수익";
            this.IncomeChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // ChildFormIncomeStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 645);
            this.Controls.Add(this.IncomeChart);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChildFormIncomeStatement";
            this.Text = "손익 계산서";
            this.Load += new System.EventHandler(this.ChildFormIncomeStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.financialStatementModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource financialStatementModelBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn col매출액;
        private DevExpress.XtraGrid.Columns.GridColumn col매출원가;
        private DevExpress.XtraGrid.Columns.GridColumn col매출총이익;
        private DevExpress.XtraGrid.Columns.GridColumn col판매비와관리비;
        private DevExpress.XtraGrid.Columns.GridColumn col영업이익;
        private DevExpress.XtraGrid.Columns.GridColumn col영업외손익;
        private DevExpress.XtraGrid.Columns.GridColumn col당기순이익;
        private DevExpress.XtraCharts.ChartControl IncomeChart;
    }
}