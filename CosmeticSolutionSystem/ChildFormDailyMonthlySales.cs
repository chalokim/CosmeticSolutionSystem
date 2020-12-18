using CosmeticSolutionSystem.Data;
using CosmeticSolutionSystem.Data.Models;
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
    public partial class ChildFormDailyMonthlySales : Form
    {
        public ChildFormDailyMonthlySales()
        {
            InitializeComponent();
        }

        private void ChildFormDailyMonthlySales_Load(object sender, EventArgs e)
        {
            InitializeControl();
        }

        private void InitializeControl()
        {
            string[] intervalArray = new string[]
            {
                "월",
                "일"
            };

            // 월/일 선택 콤보박스 아이템 추가
            foreach (var x in intervalArray)
            {
                comboBoxInterval.Items.Add(x);
            }

            comboBoxInterval.SelectedItem = "월";

            // 화면 로드 시 데이터를 조회한다
            dateTimePicker.Value = new DateTime(DateTime.Now.Year, 1, 1);
            btnSearch_Click(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if( comboBoxInterval.Text.ToString() != CosmeticConstant.DateMonth
                && comboBoxInterval.Text.ToString() != CosmeticConstant.DateDay )
            {
                MessageBox.Show("기간을 다시 선택하세요", "오류");
                return;
            }

            // 월을 선택하면
            if (comboBoxInterval.SelectedItem.ToString() == CosmeticConstant.DateMonth)
            {
                DateTime month = dateTimePicker.Value;
                List<DayMonthSalesModel> list = SalesDao.GetSalesVolumeByMonth(month);

                ChartTitle chartTitle1 = new ChartTitle();

                // Define the text for the titles.
                chartTitle1.Text = "월별 판매량";

                chartDayMonthSales.Titles.Clear();
                chartDayMonthSales.Titles.AddRange( new ChartTitle[] { chartTitle1 } );

                bindingSourceMonthDaySales.DataSource = list;

                chartDayMonthSales.Series[0].Visible = true;
                chartDayMonthSales.Series[1].Visible = false;
            }
            // 일을 선택하면 선택한 날의 카테고리별 판매 데이터를 출력한다
            else if (comboBoxInterval.SelectedItem.ToString() == CosmeticConstant.DateDay)
            {
                DateTime day = dateTimePicker.Value;
                List<DaySalesByCategoryModel> list = SalesDao.GetSalesVolumeByDay(day);

                ChartTitle chartTitle1 = new ChartTitle();

                // Define the text for the titles.
                chartTitle1.Text = "카테고리별 일별 판매량";

                chartDayMonthSales.Series[0].Visible = false;
                chartDayMonthSales.Series[1].Visible = true;

                chartDayMonthSales.Titles.Clear();
                chartDayMonthSales.Titles.AddRange(new ChartTitle[] { chartTitle1 });

                bindingSourceDaySales.DataSource = list;

                chartDayMonthSales.Series[1].Visible = true;
                chartDayMonthSales.Series[0].Visible = false;
            }
        }
    }
}
