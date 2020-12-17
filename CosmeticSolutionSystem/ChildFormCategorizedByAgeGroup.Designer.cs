
namespace CosmeticSolutionSystem
{
    partial class ChildFormCategorizedByAgeGroup
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
            DevExpress.XtraCharts.XYDiagram3D xyDiagram3D1 = new DevExpress.XtraCharts.XYDiagram3D();
            DevExpress.XtraCharts.ManhattanBarSeriesView manhattanBarSeriesView1 = new DevExpress.XtraCharts.ManhattanBarSeriesView();
            this.CategoryAgeChart = new DevExpress.XtraCharts.ChartControl();
            this.categorizedByAgeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnYear2020 = new DevExpress.XtraEditors.SimpleButton();
            this.btnYear2019 = new DevExpress.XtraEditors.SimpleButton();
            this.btnYear2018 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryAgeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(manhattanBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorizedByAgeModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryAgeChart
            // 
            this.CategoryAgeChart.DataSource = this.categorizedByAgeModelBindingSource;
            xyDiagram3D1.AxisY.Interlaced = false;
            xyDiagram3D1.AxisY.MinorCount = 2;
            xyDiagram3D1.RotationMatrixSerializable = "0.0154863763313246;-0.0149428852598034;-0.999768414348171;0;0.00271903683913421;0" +
    ".999885254377139;-0.0149025138097526;0;0.999876381852682;-0.00248762121207529;0." +
    "0155252295929321;0;0;0;0;1";
            xyDiagram3D1.RuntimeRotation = true;
            xyDiagram3D1.RuntimeScrolling = true;
            xyDiagram3D1.RuntimeZooming = true;
            xyDiagram3D1.ZoomPercent = 200;
            this.CategoryAgeChart.Diagram = xyDiagram3D1;
            this.CategoryAgeChart.Legend.Name = "Default Legend";
            this.CategoryAgeChart.Location = new System.Drawing.Point(12, 48);
            this.CategoryAgeChart.Name = "CategoryAgeChart";
            this.CategoryAgeChart.SeriesDataMember = "CategoryName";
            this.CategoryAgeChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.CategoryAgeChart.SeriesTemplate.ArgumentDataMember = "Date";
            this.CategoryAgeChart.SeriesTemplate.DateTimeSummaryOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month;
            this.CategoryAgeChart.SeriesTemplate.DateTimeSummaryOptions.MeasureUnitMultiplier = 1;
            this.CategoryAgeChart.SeriesTemplate.SeriesDataMember = "CategoryName";
            this.CategoryAgeChart.SeriesTemplate.ValueDataMembersSerializable = "Quantity";
            manhattanBarSeriesView1.BarWidth = 20D;
            this.CategoryAgeChart.SeriesTemplate.View = manhattanBarSeriesView1;
            this.CategoryAgeChart.Size = new System.Drawing.Size(776, 361);
            this.CategoryAgeChart.TabIndex = 20;
            // 
            // categorizedByAgeModelBindingSource
            // 
            this.categorizedByAgeModelBindingSource.DataSource = typeof(CosmeticSolutionSystem.Data.Models.CategorizedByAgeModel);
            // 
            // btnYear2020
            // 
            this.btnYear2020.Location = new System.Drawing.Point(456, 415);
            this.btnYear2020.Name = "btnYear2020";
            this.btnYear2020.Size = new System.Drawing.Size(130, 23);
            this.btnYear2020.TabIndex = 19;
            this.btnYear2020.Text = "2020";
            this.btnYear2020.Click += new System.EventHandler(this.btnYear2020_Click);
            // 
            // btnYear2019
            // 
            this.btnYear2019.Location = new System.Drawing.Point(320, 415);
            this.btnYear2019.Name = "btnYear2019";
            this.btnYear2019.Size = new System.Drawing.Size(130, 23);
            this.btnYear2019.TabIndex = 18;
            this.btnYear2019.Text = "2019";
            this.btnYear2019.Click += new System.EventHandler(this.btnYear2019_Click);
            // 
            // btnYear2018
            // 
            this.btnYear2018.Location = new System.Drawing.Point(184, 415);
            this.btnYear2018.Name = "btnYear2018";
            this.btnYear2018.Size = new System.Drawing.Size(130, 23);
            this.btnYear2018.TabIndex = 17;
            this.btnYear2018.Text = "2018";
            this.btnYear2018.Click += new System.EventHandler(this.btnYear2018_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.ShowLineShadow = false;
            this.labelControl2.Size = new System.Drawing.Size(776, 30);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "카테고리별 연령대별 판매량";
            // 
            // ChildFormCategorizedByAgeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CategoryAgeChart);
            this.Controls.Add(this.btnYear2020);
            this.Controls.Add(this.btnYear2019);
            this.Controls.Add(this.btnYear2018);
            this.Controls.Add(this.labelControl2);
            this.Name = "ChildFormCategorizedByAgeGroup";
            this.Text = "카테고리별 연령대별 비중 남자 - 여자";
            this.Load += new System.EventHandler(this.ChildFormCategorizedByAgeGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(manhattanBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryAgeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorizedByAgeModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl CategoryAgeChart;
        private System.Windows.Forms.BindingSource categorizedByAgeModelBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnYear2020;
        private DevExpress.XtraEditors.SimpleButton btnYear2019;
        private DevExpress.XtraEditors.SimpleButton btnYear2018;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}