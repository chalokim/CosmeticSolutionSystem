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
        int lastDayOfMonth = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);

        //차트 종류에 따른 다이어그램 선언
        XYDiagram diagram;
        public ChildFormSalesCategorizedByConfirmedCOVID19Cases()
        {
            InitializeComponent();
        }

        private void ChildFormSalesCategorizedByConfirmedCOVID19Cases_Load(object sender, EventArgs e)
        {
            covid = new ChildFormSalesCategorizedByConfirmedCOVID19Cases();
            salesModelBindingSource.DataSource = SalesDao.GetModels(SaleMonth);
            diagram = (XYDiagram)CovidChart.Diagram;
      
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

            ////diagram.AxisX.VisualRange.MinValue = new DateTime(SaleYear, SaleMonth-1, 1);
            ////diagram.AxisX.VisualRange.MaxValue = new DateTime(SaleYear, SaleMonth,1);
            diagram.AxisX.WholeRange.MinValue = new DateTime(SaleYear, SaleMonth - 3, lastDayOfMonth);
            diagram.AxisX.WholeRange.MaxValue = new DateTime(SaleYear, SaleMonth, lastDayOfMonth);


        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if(SaleYear >= DateTime.Today.Year && SaleMonth+3 >= DateTime.Today.Month)
            {
                _ = btnForward.Enabled;
            }

            diagram.AxisX.WholeRange.MinValue = new DateTime(SaleYear, SaleMonth, lastDayOfMonth);
            diagram.AxisX.WholeRange.MaxValue = new DateTime(SaleYear, SaleMonth +3, lastDayOfMonth);
            SaleMonth += 1;

        }
    }
}