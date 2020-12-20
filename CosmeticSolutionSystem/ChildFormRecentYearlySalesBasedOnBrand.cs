using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CosmeticSolutionSystem.Data.Models;
using CosmeticSolutionSystem.Data;

namespace CosmeticSolutionSystem
{
    public partial class ChildFormRecentYearlySalesBasedOnBrand : Form
    {
        public ChildFormRecentYearlySalesBasedOnBrand()
        {
            InitializeComponent();
        }

        private void dateEditSearch_EditValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(dateEditSearch.DateTime.Year, 1, 1);
            DateTime endDate = new DateTime(dateEditSearch.DateTime.Year, 12, 31);

            List<YearlyBrandModel> dataSource = Dao.Brand.GetBrand(startDate, endDate);
            yearlyBrandModelBindingSource.DataSource = dataSource;
        }
    }
}
