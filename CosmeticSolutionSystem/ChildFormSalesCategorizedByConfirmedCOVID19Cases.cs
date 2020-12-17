using CosmeticSolutionSystem.Data;
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
        int SaleDate = DateTime.Today.Month;
        public ChildFormSalesCategorizedByConfirmedCOVID19Cases()
        {
            InitializeComponent();
        }

        private void ChildFormSalesCategorizedByConfirmedCOVID19Cases_Load(object sender, EventArgs e)
        {

            ChildFormSalesCategorizedByConfirmedCOVID19Cases covid = new ChildFormSalesCategorizedByConfirmedCOVID19Cases();
            salesModelBindingSource.DataSource = SalesDao.GetModels(SaleDate);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            salesModelBindingSource.DataSource = SalesDao.GetModels(SaleDate -= 1);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            salesModelBindingSource.DataSource = SalesDao.GetModels(SaleDate += 1);
        }
    }
}