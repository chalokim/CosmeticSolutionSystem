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

    
    public partial class ChildFormCategorizedByAgeGroup : Form
    {
        public ChildFormCategorizedByAgeGroup AgeGroup;

        int DDate = DateTime.Today.Year;
       
        XYDiagram3D diagram;
        public ChildFormCategorizedByAgeGroup()
        {
            InitializeComponent();
        }
        

        private void ChildFormCategorizedByAgeGroup_Load(object sender, EventArgs e)
        {
            AgeGroup = new ChildFormCategorizedByAgeGroup();
            categorizedByAgeModelBindingSource.DataSource = SalesDao.GetModelsCategory(DDate);
            diagram = (XYDiagram3D)CategoryAgeChart.Diagram;
        }

        // Set limits for an x-axis's whole range
        //diagram.AxisX.WholeRange.MinValue = new DateTime(2017, 01, 01);
        //diagram.AxisX.WholeRange.MaxValue = new DateTime(2019, 12, 31);
        // or use the SetMinMaxValues method to specify range limits.
        //diagram.AxisX.WholeRange.SetMinMaxValues(new DateTime(2017, 01, 01), new DateTime(2019, 12, 31));

        // Set limits for an x-axis's visual range
        //diagram.AxisX.VisualRange.MinValue = new DateTime(2018, 01, 01);
        //diagram.AxisX.VisualRange.MaxValue = new DateTime(2019, 01, 01);
        // or use the SetMinMaxValues method to specify range limits.
        //diagram.AxisX.VisualRange.SetMinMaxValues(new DateTime(2018, 01, 01), new DateTime(2019, 01, 01));


        private void btnYear2018_Click(object sender, EventArgs e)
        {
            diagram.AxisX.WholeRange.MinValue = new DateTime(DDate-2, 01, 01);
            diagram.AxisX.WholeRange.MaxValue = new DateTime(DDate-2, 12, 31);

        }

        private void btnYear2019_Click(object sender, EventArgs e)
        {
            diagram.AxisX.WholeRange.MinValue = new DateTime(DDate-1, 01, 01);
            diagram.AxisX.WholeRange.MaxValue = new DateTime(DDate-1, 12, 31);
        }

        private void btnYear2020_Click(object sender, EventArgs e)
        {
            diagram.AxisX.WholeRange.MinValue = new DateTime(DDate, 01, 01);
            diagram.AxisX.WholeRange.MaxValue = new DateTime(DDate, 12, 31);
        }
    }
}
