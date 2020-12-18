using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CosmeticSolutionSystem.Data;
using DevExpress.XtraCharts;

namespace CosmeticSolutionSystem
{
    public partial class ChildFormBalanceSheet : Form
    {

        XYDiagram diagram;
        public ChildFormBalanceSheet()
        {
            InitializeComponent();
        }

        private void ChildFormBalanceSheet_Load(object sender, EventArgs e)
        {
            financialStatementModelBindingSource.DataSource = FinancialStatementDao.GetFinancialStatements();
            diagram = (XYDiagram)BalanceChart.Diagram;

            BalanceChart.Animate();
        }
    }
}
