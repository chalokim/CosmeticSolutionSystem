using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem
{
    public class CosmeticConstant
    {
        public static readonly string DateMonth = "월";
        public static readonly string DateDay = "일";
        public static readonly string DateWeek = "주";
        public static readonly string DateYear = "년";
    }

    public class ChartHelper
    {
        public static void ChangeChartTitle(DevExpress.XtraCharts.ChartControl chart, string title)
        {
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = title;

            chart.Titles.Clear();
            chart.Titles.AddRange(new ChartTitle[] { chartTitle1 });
        }
    }
}
