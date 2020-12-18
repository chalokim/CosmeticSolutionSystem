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
    public partial class ChildFormIncomeStatement : Form
    {
        XYDiagram diagram;
        public ChildFormIncomeStatement()
        {
            InitializeComponent();
        }

        private void ChildFormIncomeStatement_Load(object sender, EventArgs e)
        {
            financialStatementModelBindingSource.DataSource = FinancialStatementDao.GetFinancialStatements();
            diagram = (XYDiagram)IncomeChart.Diagram;

            IncomeChart.Animate();
        }
    }
}
