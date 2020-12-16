
namespace CosmeticSolutionSystem
{
    partial class ChildFormRecentYearlySalesBasedOnBrand
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
            //this.cosmeticSolutionSystemDataSet = new CosmeticSolutionSystem.CosmeticSolutionSystemDataSet();
            this.cosmeticSolutionSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            //((System.ComponentModel.ISupportInitialize)(this.cosmeticSolutionSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticSolutionSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // cosmeticSolutionSystemDataSet
            // 
            //this.cosmeticSolutionSystemDataSet.DataSetName = "CosmeticSolutionSystemDataSet";
           // this.cosmeticSolutionSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cosmeticSolutionSystemDataSetBindingSource
            // 
            //this.cosmeticSolutionSystemDataSetBindingSource.DataSource = this.cosmeticSolutionSystemDataSet;
            this.cosmeticSolutionSystemDataSetBindingSource.Position = 0;
            // 
            // chartControl
            // 
            this.chartControl.DataSource = this.cosmeticSolutionSystemDataSetBindingSource;
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl.Diagram = xyDiagram1;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Location = new System.Drawing.Point(0, 0);
            this.chartControl.Name = "chartControl";
            this.chartControl.SeriesDataMember = "Brand.BrandName";
            series1.ArgumentDataMember = "Brand.BrandName";
            series1.DataSource = this.cosmeticSolutionSystemDataSetBindingSource;
            series1.DataSourceSorted = true;
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "Brand.BrandId";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl.SeriesTemplate.ArgumentDataMember = "재무제표.매출액";
            this.chartControl.SeriesTemplate.SeriesDataMember = "Brand.BrandName";
            this.chartControl.Size = new System.Drawing.Size(914, 562);
            this.chartControl.TabIndex = 0;
            // 
            // ChildFormRecentYearlySalesBasedOnBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.chartControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChildFormRecentYearlySalesBasedOnBrand";
            this.Text = "브랜드별 최근 1년 월 매출";
            //((System.ComponentModel.ISupportInitialize)(this.cosmeticSolutionSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticSolutionSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private CosmeticSolutionSystemDataSet cosmeticSolutionSystemDataSet;
        private System.Windows.Forms.BindingSource cosmeticSolutionSystemDataSetBindingSource;
        private DevExpress.XtraCharts.ChartControl chartControl;
    }
}