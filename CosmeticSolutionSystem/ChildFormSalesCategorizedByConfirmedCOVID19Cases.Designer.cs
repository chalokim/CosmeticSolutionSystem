
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
            DevExpress.XtraCharts.XYDiagram3D xyDiagram3D1 = new DevExpress.XtraCharts.XYDiagram3D();
            DevExpress.XtraCharts.Line3DSeriesView line3DSeriesView1 = new DevExpress.XtraCharts.Line3DSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.cosmeticSolutionSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticSolutionSystemDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.cosmeticSolutionSystemDataSetBindingSource;
            xyDiagram3D1.AxisY.Interlaced = false;
            xyDiagram3D1.AxisY.MinorCount = 2;
            xyDiagram3D1.RotationMatrixSerializable = "0.732770661791947;-0.501716913855184;0.459703486574364;0;0.279537285792133;0.8378" +
    "70946712044;0.468861581394592;0;-0.620407981145443;-0.215063746381156;0.75421583" +
    "2453512;0;0;0;0;1";
            this.chartControl1.Diagram = xyDiagram3D1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(27, 48);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "CategoryName";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Date";
            this.chartControl1.SeriesTemplate.SeriesDataMember = "CategoryName";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "TotalPrice";
            this.chartControl1.SeriesTemplate.View = line3DSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(750, 347);
            this.chartControl1.TabIndex = 9;
            // 
            // cosmeticSolutionSystemDataSetBindingSource
            // 
            this.cosmeticSolutionSystemDataSetBindingSource.DataSource = typeof(CosmeticSolutionSystem.Data.Models.SalesModel);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(94, 402);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(82, 36);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "<";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(602, 402);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(82, 36);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = ">";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(398, 402);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(188, 36);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "이번달";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(193, 402);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(188, 36);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "저번달";
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
            this.labelControl2.Text = "3개월간 코로나 확진자 수에 따른 카테고리별 판매량";
            // 
            // ChildFormSalesCategorizedByConfirmedCOVID19Cases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "ChildFormSalesCategorizedByConfirmedCOVID19Cases";
            this.Text = "코로나 확진자 수에 따른 카테고리별 판매량";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticSolutionSystemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource cosmeticSolutionSystemDataSetBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}