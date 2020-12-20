
namespace CosmeticSolutionSystem
{
    partial class ChildFormTopWorstProduct
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
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView3 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel3 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView3 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            this.bindingSourceTopProduct = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxTerm = new System.Windows.Forms.ComboBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.chartPie = new DevExpress.XtraCharts.ChartControl();
            this.bindingSourceTopProduct2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTopProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTopProduct2)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceTopProduct
            // 
            this.bindingSourceTopProduct.DataSource = typeof(CosmeticSolutionSystem.Data.Models.TopWorstProductModel);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.numericUpDownCount);
            this.layoutControl1.Controls.Add(this.dateTimePicker);
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.comboBoxTerm);
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(536, 57);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(405, 12);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownCount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(45, 21);
            this.numericUpDownCount.TabIndex = 8;
            this.numericUpDownCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(187, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(158, 21);
            this.dateTimePicker.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(454, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 21);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBoxTerm
            // 
            this.comboBoxTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTerm.FormattingEnabled = true;
            this.comboBoxTerm.Location = new System.Drawing.Point(68, 12);
            this.comboBoxTerm.Name = "comboBoxTerm";
            this.comboBoxTerm.Size = new System.Drawing.Size(59, 20);
            this.comboBoxTerm.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(536, 57);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 25);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(516, 12);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.comboBoxTerm;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(119, 25);
            this.layoutControlItem2.Text = "기간";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(44, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateTimePicker;
            this.layoutControlItem1.Location = new System.Drawing.Point(119, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(218, 25);
            this.layoutControlItem1.Text = "날짜";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(44, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSearch;
            this.layoutControlItem3.Location = new System.Drawing.Point(442, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(74, 25);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.numericUpDownCount;
            this.layoutControlItem4.Location = new System.Drawing.Point(337, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(105, 25);
            this.layoutControlItem4.Text = "조회 개수";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(44, 14);
            // 
            // chartControl1
            // 
            this.chartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartControl1.DataSource = this.bindingSourceTopProduct;
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram3.LabelsResolveOverlappingMinIndent = 0;
            this.chartControl1.Diagram = xyDiagram3;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(9, 88);
            this.chartControl1.Name = "chartControl1";
            series5.ArgumentDataMember = "ProductName";
            series5.DataSource = this.bindingSourceTopProduct;
            series5.Name = "Series 1";
            series5.ValueDataMembersSerializable = "Quantity";
            sideBySideBarSeriesView3.BarWidth = 0.5D;
            sideBySideBarSeriesView3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            series5.View = sideBySideBarSeriesView3;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "ProductName";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Quantity";
            this.chartControl1.SideBySideBarDistanceFixed = 5;
            this.chartControl1.SideBySideBarDistanceVariable = 1D;
            this.chartControl1.Size = new System.Drawing.Size(378, 224);
            this.chartControl1.TabIndex = 8;
            // 
            // chartPie
            // 
            this.chartPie.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartPie.DataSource = this.bindingSourceTopProduct2;
            this.chartPie.Legend.Name = "Default Legend";
            this.chartPie.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartPie.Location = new System.Drawing.Point(422, 88);
            this.chartPie.Name = "chartPie";
            series6.ArgumentDataMember = "ProductName";
            doughnutSeriesLabel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doughnutSeriesLabel3.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            doughnutSeriesLabel3.TextPattern = "{A}:{V}({VP:P1})";
            series6.Label = doughnutSeriesLabel3;
            series6.Name = "Series 1";
            series6.ValueDataMembersSerializable = "Quantity";
            doughnutSeriesView3.TotalLabel.TextPattern = "Total {TV}(100%)";
            doughnutSeriesView3.TotalLabel.Visible = true;
            series6.View = doughnutSeriesView3;
            this.chartPie.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series6};
            this.chartPie.SeriesTemplate.ArgumentDataMember = "ProductName";
            this.chartPie.SeriesTemplate.ValueDataMembersSerializable = "Quantity";
            this.chartPie.Size = new System.Drawing.Size(300, 224);
            this.chartPie.TabIndex = 9;
            this.chartPie.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle3});
            // 
            // bindingSourceTopProduct2
            // 
            this.bindingSourceTopProduct2.DataSource = typeof(CosmeticSolutionSystem.Data.Models.TopWorstProductModel);
            // 
            // ChildFormTopWorstProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartPie);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.chartControl1);
            this.Name = "ChildFormTopWorstProduct";
            this.Text = "Top 5 제품";
            this.Load += new System.EventHandler(this.ChildFormTopWorstProduct_Load);
            this.SizeChanged += new System.EventHandler(this.ChildFormTopWorstProduct_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTopProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTopProduct2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxTerm;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource bindingSourceTopProduct;
        private DevExpress.XtraCharts.ChartControl chartPie;
        private System.Windows.Forms.BindingSource bindingSourceTopProduct2;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}