
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
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.CovidChart = new DevExpress.XtraCharts.ChartControl();
            this.btnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnForward = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.salesModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CovidChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(31, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.ShowLineShadow = false;
            this.labelControl2.Size = new System.Drawing.Size(857, 37);
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
            this.CovidChart.Diagram = xyDiagram1;
            this.CovidChart.Legend.Name = "Default Legend";
            this.CovidChart.Location = new System.Drawing.Point(28, 60);
            this.CovidChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CovidChart.Name = "CovidChart";
            this.CovidChart.PaletteName = "Concourse";
            this.CovidChart.SeriesDataMember = "CategoryName";
            this.CovidChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.CovidChart.SeriesTemplate.ArgumentDataMember = "Date";
            this.CovidChart.SeriesTemplate.DateTimeSummaryOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month;
            this.CovidChart.SeriesTemplate.DateTimeSummaryOptions.MeasureUnitMultiplier = 5;
            this.CovidChart.SeriesTemplate.SeriesDataMember = "CategoryName";
            this.CovidChart.SeriesTemplate.ValueDataMembersSerializable = "Quantity";
            this.CovidChart.SeriesTemplate.View = stackedBarSeriesView1;
            this.CovidChart.SideBySideBarDistanceVariable = 5D;
            this.CovidChart.Size = new System.Drawing.Size(874, 435);
            this.CovidChart.TabIndex = 12;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(47, 519);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(149, 29);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "<";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(689, 519);
            this.btnForward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(149, 29);
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
            this.labelControl3.Location = new System.Drawing.Point(446, 519);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(237, 29);
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
            this.labelControl1.Location = new System.Drawing.Point(202, 519);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(237, 29);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "저번달";
            // 
            // salesModelBindingSource
            // 
            this.salesModelBindingSource.DataSource = typeof(CosmeticSolutionSystem.Data.Models.SalesModel);
            // 
            // ChildFormSalesCategorizedByConfirmedCOVID19Cases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.CovidChart);
            this.Controls.Add(this.labelControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChildFormSalesCategorizedByConfirmedCOVID19Cases";
            this.Text = "코로나 확진자 수에 따른 카테고리별 판매량";
            this.Load += new System.EventHandler(this.ChildFormSalesCategorizedByConfirmedCOVID19Cases_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
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
    }
}