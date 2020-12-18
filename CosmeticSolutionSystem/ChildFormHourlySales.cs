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
using CosmeticSolutionSystem.Data.Models;

namespace CosmeticSolutionSystem
{
    public partial class ChildFormHourlySales : Form
    {
        public ChildFormHourlySales()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void ChildFormHourlySales_Load(object sender, EventArgs e)
        {
            
        }
   
        private void dateEditSearch_SelectionChanged(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(dateEditSearch.DateTime.Year, 1, 1);
            DateTime endDate = new DateTime(dateEditSearch.DateTime.Year, 12, 31);

            List<HourlySales> dataSource = Dao.Sales.SearchDate(startDate, endDate);
            hourlySalesModelBindingSource.DataSource = dataSource;
        }
    }
}
