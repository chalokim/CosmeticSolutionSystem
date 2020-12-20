
namespace CosmeticSolutionSystem
{
    partial class ChildFormDailyMonthlySales
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
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView2 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            this.bindingSourceDaySales = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSalesVolumeDayCategoryModel = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.checkBoxCategory = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxInterval = new System.Windows.Forms.ComboBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chartDayMonthSales = new DevExpress.XtraCharts.ChartControl();
            this.bindingSourceMonthDaySales = new System.Windows.Forms.BindingSource(this.components);
            this.chartControlSalesVolumeMonthCategory = new DevExpress.XtraCharts.ChartControl();
            this.bindingSourceSalesVolumeMonthCategoryModel = new System.Windows.Forms.BindingSource(this.components);
            this.chartControlSalesVolumeDayCategory = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDaySales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSalesVolumeDayCategoryModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDayMonthSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMonthDaySales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlSalesVolumeMonthCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSalesVolumeMonthCategoryModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlSalesVolumeDayCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceDaySales
            // 
            this.bindingSourceDaySales.DataSource = typeof(CosmeticSolutionSystem.Data.Models.DaySalesByCategoryModel);
            // 
            // bindingSourceSalesVolumeDayCategoryModel
            // 
            this.bindingSourceSalesVolumeDayCategoryModel.DataSource = typeof(CosmeticSolutionSystem.Data.Models.SalesVolumeMonthCategoryModel);
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.checkBoxCategory);
            this.layoutControl.Controls.Add(this.btnSearch);
            this.layoutControl.Controls.Add(this.dateTimePicker);
            this.layoutControl.Controls.Add(this.comboBoxInterval);
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(545, 66);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // checkBoxCategory
            // 
            this.checkBoxCategory.Location = new System.Drawing.Point(123, 12);
            this.checkBoxCategory.Name = "checkBoxCategory";
            this.checkBoxCategory.Size = new System.Drawing.Size(106, 20);
            this.checkBoxCategory.TabIndex = 9;
            this.checkBoxCategory.Text = "카테고리";
            this.checkBoxCategory.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(474, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 20);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(265, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(205, 21);
            this.dateTimePicker.TabIndex = 8;
            // 
            // comboBoxInterval
            // 
            this.comboBoxInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInterval.FormattingEnabled = true;
            this.comboBoxInterval.Location = new System.Drawing.Point(44, 12);
            this.comboBoxInterval.Name = "comboBoxInterval";
            this.comboBoxInterval.Size = new System.Drawing.Size(75, 20);
            this.comboBoxInterval.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(545, 66);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(462, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(63, 22);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.comboBoxInterval;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(111, 46);
            this.layoutControlItem3.Text = "기간";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(20, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateTimePicker;
            this.layoutControlItem2.Location = new System.Drawing.Point(221, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(241, 46);
            this.layoutControlItem2.Text = "날짜";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(20, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSearch;
            this.layoutControlItem1.Location = new System.Drawing.Point(462, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(63, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.checkBoxCategory;
            this.layoutControlItem4.Location = new System.Drawing.Point(111, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(110, 46);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // chartDayMonthSales
            // 
            this.chartDayMonthSales.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartDayMonthSales.DataSource = this.bindingSourceMonthDaySales;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartDayMonthSales.Diagram = xyDiagram1;
            this.chartDayMonthSales.Legend.Name = "Default Legend";
            this.chartDayMonthSales.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartDayMonthSales.Location = new System.Drawing.Point(0, 260);
            this.chartDayMonthSales.Name = "chartDayMonthSales";
            series1.ArgumentDataMember = "Date";
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "SalesVolume";
            sideBySideBarSeriesView1.BarWidth = 20D;
            series1.View = sideBySideBarSeriesView1;
            series2.ArgumentDataMember = "CategoryName";
            series2.DataSource = this.bindingSourceDaySales;
            series2.Name = "Series 2";
            series2.ValueDataMembersSerializable = "Quantity";
            this.chartDayMonthSales.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartDayMonthSales.Size = new System.Drawing.Size(800, 190);
            this.chartDayMonthSales.TabIndex = 4;
            chartTitle1.Text = "판매량";
            this.chartDayMonthSales.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // bindingSourceMonthDaySales
            // 
            this.bindingSourceMonthDaySales.DataSource = typeof(CosmeticSolutionSystem.Data.Models.DayMonthSalesModel);
            // 
            // chartControlSalesVolumeMonthCategory
            // 
            this.chartControlSalesVolumeMonthCategory.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartControlSalesVolumeMonthCategory.DataSource = this.bindingSourceSalesVolumeMonthCategoryModel;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlSalesVolumeMonthCategory.Diagram = xyDiagram2;
            this.chartControlSalesVolumeMonthCategory.Legend.Name = "Default Legend";
            this.chartControlSalesVolumeMonthCategory.Location = new System.Drawing.Point(33, 72);
            this.chartControlSalesVolumeMonthCategory.Name = "chartControlSalesVolumeMonthCategory";
            this.chartControlSalesVolumeMonthCategory.SeriesDataMember = "CategoryName";
            this.chartControlSalesVolumeMonthCategory.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControlSalesVolumeMonthCategory.SeriesTemplate.ArgumentDataMember = "Date";
            this.chartControlSalesVolumeMonthCategory.SeriesTemplate.SeriesDataMember = "CategoryName";
            this.chartControlSalesVolumeMonthCategory.SeriesTemplate.ValueDataMembersSerializable = "Quantity";
            stackedBarSeriesView1.BarWidth = 20D;
            this.chartControlSalesVolumeMonthCategory.SeriesTemplate.View = stackedBarSeriesView1;
            this.chartControlSalesVolumeMonthCategory.Size = new System.Drawing.Size(363, 115);
            this.chartControlSalesVolumeMonthCategory.TabIndex = 5;
            this.chartControlSalesVolumeMonthCategory.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // bindingSourceSalesVolumeMonthCategoryModel
            // 
            this.bindingSourceSalesVolumeMonthCategoryModel.DataSource = typeof(CosmeticSolutionSystem.Data.Models.SalesVolumeMonthCategoryModel);
            // 
            // chartControlSalesVolumeDayCategory
            // 
            this.chartControlSalesVolumeDayCategory.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartControlSalesVolumeDayCategory.DataSource = this.bindingSourceSalesVolumeDayCategoryModel;
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlSalesVolumeDayCategory.Diagram = xyDiagram3;
            this.chartControlSalesVolumeDayCategory.Legend.Name = "Default Legend";
            this.chartControlSalesVolumeDayCategory.Location = new System.Drawing.Point(416, 88);
            this.chartControlSalesVolumeDayCategory.Name = "chartControlSalesVolumeDayCategory";
            this.chartControlSalesVolumeDayCategory.SeriesDataMember = "CategoryName";
            this.chartControlSalesVolumeDayCategory.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControlSalesVolumeDayCategory.SeriesTemplate.ArgumentDataMember = "Date";
            this.chartControlSalesVolumeDayCategory.SeriesTemplate.SeriesDataMember = "CategoryName";
            this.chartControlSalesVolumeDayCategory.SeriesTemplate.ValueDataMembersSerializable = "Quantity";
            this.chartControlSalesVolumeDayCategory.SeriesTemplate.View = stackedBarSeriesView2;
            this.chartControlSalesVolumeDayCategory.Size = new System.Drawing.Size(242, 153);
            this.chartControlSalesVolumeDayCategory.TabIndex = 6;
            this.chartControlSalesVolumeDayCategory.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle3});
            // 
            // ChildFormDailyMonthlySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartControlSalesVolumeDayCategory);
            this.Controls.Add(this.chartControlSalesVolumeMonthCategory);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.chartDayMonthSales);
            this.Name = "ChildFormDailyMonthlySales";
            this.Text = "일별 월별 판매량";
            this.Load += new System.EventHandler(this.ChildFormDailyMonthlySales_Load);
            this.SizeChanged += new System.EventHandler(this.ChildFormDailyMonthlySales_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDaySales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSalesVolumeDayCategoryModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDayMonthSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMonthDaySales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlSalesVolumeMonthCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSalesVolumeMonthCategoryModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlSalesVolumeDayCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxInterval;
        private DevExpress.XtraCharts.ChartControl chartDayMonthSales;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource bindingSourceMonthDaySales;
        private System.Windows.Forms.BindingSource bindingSourceDaySales;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraCharts.ChartControl chartControlSalesVolumeMonthCategory;
        private System.Windows.Forms.BindingSource bindingSourceSalesVolumeMonthCategoryModel;
        private System.Windows.Forms.CheckBox checkBoxCategory;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource bindingSourceSalesVolumeDayCategoryModel;
        private DevExpress.XtraCharts.ChartControl chartControlSalesVolumeDayCategory;
    }
}