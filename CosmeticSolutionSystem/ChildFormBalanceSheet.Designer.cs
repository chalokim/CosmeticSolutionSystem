
namespace CosmeticSolutionSystem
{
    partial class ChildFormBalanceSheet
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.BalanceChart = new DevExpress.XtraCharts.ChartControl();
            this.financialStatementModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col자산 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col부채 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col자본 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialStatementModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BalanceChart
            // 
            this.BalanceChart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.BalanceChart.DataSource = this.financialStatementModelBindingSource;
            xyDiagram1.AxisX.NumericScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.Title.Font = new System.Drawing.Font("Tahoma", 10F);
            xyDiagram1.AxisX.Title.Text = "년도";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 10F);
            xyDiagram1.AxisY.Title.Text = "금액(단위: 만 원)";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.BalanceChart.Diagram = xyDiagram1;
            this.BalanceChart.Legend.Name = "Default Legend";
            this.BalanceChart.Location = new System.Drawing.Point(17, 23);
            this.BalanceChart.Name = "BalanceChart";
            series1.ArgumentDataMember = "year";
            series1.Name = "자산";
            series1.ValueDataMembersSerializable = "자산";
            series2.ArgumentDataMember = "year";
            series2.Name = "부채";
            series2.ValueDataMembersSerializable = "부채";
            series3.ArgumentDataMember = "year";
            series3.Name = "자본";
            series3.ValueDataMembersSerializable = "자본";
            this.BalanceChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            this.BalanceChart.Size = new System.Drawing.Size(879, 357);
            this.BalanceChart.TabIndex = 0;
            chartTitle1.Text = "2016년~2020년 재무상태";
            this.BalanceChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // financialStatementModelBindingSource
            // 
            this.financialStatementModelBindingSource.DataSource = typeof(CosmeticSolutionSystem.Data.Models.FinancialStatementModel);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.financialStatementModelBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(21, 405);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(874, 227);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYear,
            this.col자산,
            this.col부채,
            this.col자본});
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
            // col자산
            // 
            this.col자산.FieldName = "자산";
            this.col자산.MinWidth = 25;
            this.col자산.Name = "col자산";
            this.col자산.OptionsColumn.ReadOnly = true;
            this.col자산.Visible = true;
            this.col자산.VisibleIndex = 1;
            this.col자산.Width = 94;
            // 
            // col부채
            // 
            this.col부채.FieldName = "부채";
            this.col부채.MinWidth = 25;
            this.col부채.Name = "col부채";
            this.col부채.OptionsColumn.ReadOnly = true;
            this.col부채.Visible = true;
            this.col부채.VisibleIndex = 2;
            this.col부채.Width = 94;
            // 
            // col자본
            // 
            this.col자본.FieldName = "자본";
            this.col자본.MinWidth = 25;
            this.col자본.Name = "col자본";
            this.col자본.OptionsColumn.ReadOnly = true;
            this.col자본.Visible = true;
            this.col자본.VisibleIndex = 3;
            this.col자본.Width = 94;
            // 
            // ChildFormBalanceSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 756);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.BalanceChart);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChildFormBalanceSheet";
            this.Text = "재무 상태표";
            this.Load += new System.EventHandler(this.ChildFormBalanceSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialStatementModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl BalanceChart;
        private System.Windows.Forms.BindingSource financialStatementModelBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn col자산;
        private DevExpress.XtraGrid.Columns.GridColumn col부채;
        private DevExpress.XtraGrid.Columns.GridColumn col자본;
    }
}