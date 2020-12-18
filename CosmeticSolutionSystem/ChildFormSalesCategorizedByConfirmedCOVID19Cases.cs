using CosmeticSolutionSystem.Data;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmeticSolutionSystem
{
    public partial class ChildFormSalesCategorizedByConfirmedCOVID19Cases : Form
    {
        
        public ChildFormSalesCategorizedByConfirmedCOVID19Cases covid;
        int SaleYear = DateTime.Today.Year;
        int SaleMonth = DateTime.Today.Month;

        //차트 종류에 따른 다이어그램 선언
        XYDiagram diagram;
        public ChildFormSalesCategorizedByConfirmedCOVID19Cases()
        {
            InitializeComponent();
        }

        private void ChildFormSalesCategorizedByConfirmedCOVID19Cases_Load(object sender, EventArgs e)
        {
            
            //MessageBox.Show(now.ToString());
            covid = new ChildFormSalesCategorizedByConfirmedCOVID19Cases();
            salesModelBindingSource.DataSource = Dao.Sales.GetCovid(SaleMonth);
            diagram = (XYDiagram)CovidChart.Diagram;

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (SaleMonth == 1)
            {
                SaleMonth = 12;
                SaleYear -= 1;
            }
            diagram.AxisX.WholeRange.MinValue = new DateTime(SaleYear, SaleMonth, 1);
            diagram.AxisX.WholeRange.MaxValue = new DateTime(SaleYear, SaleMonth, DateTime.DaysInMonth(SaleYear,SaleMonth));
            SaleMonth -= 1;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (SaleMonth == 12)
            {
                SaleMonth = 1;
                SaleYear += 1;
            }
            diagram.AxisX.WholeRange.MinValue = new DateTime(SaleYear, SaleMonth, 1);
            diagram.AxisX.WholeRange.MaxValue = new DateTime(SaleYear, SaleMonth, DateTime.DaysInMonth(SaleYear, SaleMonth));
            SaleMonth += 1;
        }
    }
}