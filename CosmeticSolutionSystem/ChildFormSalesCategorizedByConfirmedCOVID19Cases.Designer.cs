
namespace CosmeticSolutionSystem
{
    partial class ChildFormSalesCategorizedByConfirmedCOVID19Cases
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
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY1 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            this.covidModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.CovidChart = new DevExpress.XtraCharts.ChartControl();
            this.salesModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnForward = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.covidModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CovidChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // covidModelBindingSource
            // 
            this.covidModelBindingSource.DataSource = typeof(CosmeticSolutionSystem.Data.Models.CovidModel);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.ShowLineShadow = false;
            this.labelControl2.Size = new System.Drawing.Size(750, 30);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "5개월간 코로나 확진자 수에 따른 카테고리별 판매량";
            // 
            // CovidChart
            // 
            this.CovidChart.DataSource = this.salesModelBindingSource;
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month;
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month;
            xyDiagram1.AxisX.MinorCount = 3;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 2.5D;
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 2.5D;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            secondaryAxisY1.AxisID = 0;
            secondaryAxisY1.Name = "Secondary AxisY 1";
            secondaryAxisY1.VisibleInPanesSerializable = "-1";
            xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1});
            this.CovidChart.Diagram = xyDiagram1;
            this.CovidChart.Legend.Name = "Default Legend";
            this.CovidChart.Location = new System.Drawing.Point(24, 48);
            this.CovidChart.Name = "CovidChart";
            this.CovidChart.PaletteName = "Concourse";
            this.CovidChart.SeriesDataMember = "CategoryName";
            series1.ArgumentDataMember = "Month";
            series1.DataSource = this.covidModelBindingSource;
            pointSeriesLabel1.LineStyle.Thickness = 10;
            series1.Label = pointSeriesLabel1;
            series1.Name = "확진자 수";
            series1.ValueDataMembersSerializable = "ConfirmedCount";
            lineSeriesView1.AxisYName = "Secondary AxisY 1";
            lineSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            series1.View = lineSeriesView1;
            this.CovidChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.CovidChart.SeriesTemplate.ArgumentDataMember = "Date";
            this.CovidChart.SeriesTemplate.DateTimeSummaryOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month;
            this.CovidChart.SeriesTemplate.DateTimeSummaryOptions.MeasureUnitMultiplier = 5;
            this.CovidChart.SeriesTemplate.SeriesDataMember = "CategoryName";
            this.CovidChart.SeriesTemplate.ValueDataMembersSerializable = "Quantity";
            this.CovidChart.SeriesTemplate.View = stackedBarSeriesView1;
            this.CovidChart.SideBySideBarDistanceVariable = 5D;
            this.CovidChart.Size = new System.Drawing.Size(765, 348);
            this.CovidChart.TabIndex = 12;
            // 
            // salesModelBindingSource
            // 
            this.salesModelBindingSource.DataSource = typeof(CosmeticSolutionSystem.Data.Models.SalesModel);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(41, 415);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(130, 23);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "<";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(603, 415);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(130, 23);
            this.btnForward.TabIndex = 19;
            this.btnForward.Text = ">";
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(390, 415);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(207, 23);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "이번달";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(177, 415);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(207, 23);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "저번달";
            // 
            // ChildFormSalesCategorizedByConfirmedCOVID19Cases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.CovidChart);
            this.Controls.Add(this.labelControl2);
            this.Name = "ChildFormSalesCategorizedByConfirmedCOVID19Cases";
            this.Text = "코로나 확진자 수에 따른 카테고리별 판매량";
            this.Load += new System.EventHandler(this.ChildFormSalesCategorizedByConfirmedCOVID19Cases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.covidModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CovidChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraCharts.ChartControl CovidChart;
        private DevExpress.XtraEditors.SimpleButton btnPrevious;
        private DevExpress.XtraEditors.SimpleButton btnForward;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource salesModelBindingSource;
        private System.Windows.Forms.BindingSource covidModelBindingSource;
    }
}