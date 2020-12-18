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
    public partial class ChildFormSalesOfVeganCosmetic : Form
    {
        XYDiagram diagram;
        public ChildFormSalesOfVeganCosmetic()
        {
            InitializeComponent();
        }

        private void ChildFormSalesOfVeganCosmetic_Load(object sender, EventArgs e)
        {
            veganBrandModelBindingSource.DataSource = Dao.Sales.VeganSalesPerYear(3);

        }
    }
}
