
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
            this.categorizedByAgeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnYear2020 = new DevExpress.XtraEditors.SimpleButton();
            this.btnYear2019 = new DevExpress.XtraEditors.SimpleButton();
            this.btnYear2018 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.CategoryAgeChart = new DevExpress.XtraCharts.ChartControl();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.categorizedByAgeModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryAgeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(manhattanBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // categorizedByAgeModelBindingSource
            // 
            this.categorizedByAgeModelBindingSource.DataSource = typeof(CosmeticSolutionSystem.Data.Models.CategorizedByAgeModel);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.CategoryAgeChart);
            this.layoutControl1.Controls.Add(this.btnYear2020);
            this.layoutControl1.Controls.Add(this.btnYear2019);
            this.layoutControl1.Controls.Add(this.btnYear2018);
            this.layoutControl1.Controls.Add(this.labelControl2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnYear2020
            // 
            this.btnYear2020.Location = new System.Drawing.Point(552, 416);
            this.btnYear2020.Name = "btnYear2020";
            this.btnYear2020.Size = new System.Drawing.Size(125, 22);
            this.btnYear2020.StyleController = this.layoutControl1;
            this.btnYear2020.TabIndex = 29;
            this.btnYear2020.Text = "2020";
            this.btnYear2020.Click += new System.EventHandler(this.btnYear2020_Click);
            // 
            // btnYear2019
            // 
            this.btnYear2019.Location = new System.Drawing.Point(347, 416);
            this.btnYear2019.Name = "btnYear2019";
            this.btnYear2019.Size = new System.Drawing.Size(125, 22);
            this.btnYear2019.StyleController = this.layoutControl1;
            this.btnYear2019.TabIndex = 28;
            this.btnYear2019.Text = "2019";
            this.btnYear2019.Click += new System.EventHandler(this.btnYear2019_Click);
            // 
            // btnYear2018
            // 
            this.btnYear2018.Location = new System.Drawing.Point(131, 416);
            this.btnYear2018.Name = "btnYear2018";
            this.btnYear2018.Size = new System.Drawing.Size(127, 22);
            this.btnYear2018.StyleController = this.layoutControl1;
            this.btnYear2018.TabIndex = 27;
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
            this.labelControl2.StyleController = this.layoutControl1;
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "카테고리별 연령대별 판매량";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem4,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem3,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.labelControl2;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 34);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnYear2018;
            this.layoutControlItem3.Location = new System.Drawing.Point(119, 404);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(131, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(669, 404);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(111, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(250, 404);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(85, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 404);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(119, 26);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnYear2019;
            this.layoutControlItem4.Location = new System.Drawing.Point(335, 404);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(129, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnYear2020;
            this.layoutControlItem5.Location = new System.Drawing.Point(540, 404);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(129, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(464, 404);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(76, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // CategoryAgeChart
            // 
            this.CategoryAgeChart.DataSource = this.categorizedByAgeModelBindingSource;
            xyDiagram3D1.AxisY.Interlaced = false;
            xyDiagram3D1.AxisY.MinorCount = 2;
            xyDiagram3D1.RotationMatrixSerializable = "0.998924461781842;0.0418109125684172;0.0200441324101293;0;-0.040934702934206;0.99" +
    "8266277910426;-0.0422940714825837;0;-0.0217777351799225;0.0414280819865204;0.998" +
    "904121662028;0;0;0;0;1";
            xyDiagram3D1.RuntimeRotation = true;
            xyDiagram3D1.RuntimeScrolling = true;
            xyDiagram3D1.RuntimeZooming = true;
            xyDiagram3D1.ZoomPercent = 230;
            this.CategoryAgeChart.Diagram = xyDiagram3D1;
            this.CategoryAgeChart.Legend.Name = "Default Legend";
            this.CategoryAgeChart.Location = new System.Drawing.Point(12, 46);
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
            this.CategoryAgeChart.Size = new System.Drawing.Size(776, 366);
            this.CategoryAgeChart.TabIndex = 1;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.CategoryAgeChart;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 370);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ChildFormCategorizedByAgeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ChildFormCategorizedByAgeGroup";
            this.Text = "카테고리별 연령대별 비중 남자 - 여자";
            this.Load += new System.EventHandler(this.ChildFormCategorizedByAgeGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categorizedByAgeModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(manhattanBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryAgeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource categorizedByAgeModelBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnYear2018;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.SimpleButton btnYear2019;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnYear2020;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraCharts.ChartControl CategoryAgeChart;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}