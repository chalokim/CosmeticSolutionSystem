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
            //layoutControl1.Hide();
            //chartDayMonthSales.Hide();
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

            checkBoxCategory.Checked = true;
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

                // 카테고리 선택했을 때
                if (checkBoxCategory.Checked == true)
                {
                    chartDayMonthSales.Hide();
                    chartControlSalesVolumeDayCategory.Hide();
                    chartControlSalesVolumeMonthCategory.Show();

                    List<SalesVolumeMonthCategoryModel> list = SalesDao.GetSalesVolumeByMonthCategory(month);

                    ChartHelper.ChangeChartTitle(chartControlSalesVolumeMonthCategory, string.Format($"카테고리별 월별 판매량 ({month.Year}.{month.Month} - {month.AddMonths(11).Year}.{month.AddMonths(11).Month})"));

                    //BarSeriesView view = chartControlSalesVolumeMonthCategory.SeriesTemplate.View as BarSeriesView;
                    //view.BarWidth = 20;

                    bindingSourceSalesVolumeMonthCategoryModel.DataSource = list;
                }
                else
                {
                    List<DayMonthSalesModel> list = SalesDao.GetSalesVolumeByMonth(month);

                    ChartHelper.ChangeChartTitle(chartDayMonthSales, string.Format($"월별 판매량 ({month.Year}.{month.Month} - {month.AddMonths(11).Year}.{month.AddMonths(11).Month})"));
                    ChartTitle chartTitle1 = new ChartTitle();

                    bindingSourceMonthDaySales.DataSource = list;

                    chartDayMonthSales.Series[0].Visible = true;
                    chartDayMonthSales.Series[1].Visible = false;

                    chartDayMonthSales.Show();
                    chartControlSalesVolumeMonthCategory.Hide();
                    chartControlSalesVolumeDayCategory.Hide();
                }
            }
            // 일을 선택하면 선택한 날의 카테고리별 판매 데이터를 출력한다
            else if (comboBoxInterval.SelectedItem.ToString() == CosmeticConstant.DateDay)
            {
                DateTime day = dateTimePicker.Value;

                if (checkBoxCategory.Checked == true)
                {
                    chartDayMonthSales.Hide();
                    chartControlSalesVolumeMonthCategory.Hide();
                    chartControlSalesVolumeDayCategory.Show();

                    List<SalesVolumeMonthCategoryModel> list = SalesDao.GetSalesVolumeByDayCategory(day);

                    ChartHelper.ChangeChartTitle(chartControlSalesVolumeDayCategory, string.Format($"카테고리별 일별 판매량 ({day.Year}.{day.Month}.{day.Day} - {day.AddDays(6).Year}.{day.AddDays(6).Month}.{day.AddDays(6).Day})"));

                    BarSeriesView view = chartControlSalesVolumeDayCategory.SeriesTemplate.View as BarSeriesView;
                    view.BarWidth = 0.3D;

                    bindingSourceSalesVolumeDayCategoryModel.DataSource = list;
                }
                else
                {
                    List<DaySalesByCategoryModel> list = SalesDao.GetSalesVolumeByDay(day);

                    ChartHelper.ChangeChartTitle(chartDayMonthSales, string.Format($"판매량 {day.Year}.{day.Month}.{day.Day}"));
                    ChartTitle chartTitle1 = new ChartTitle();

                    bindingSourceDaySales.DataSource = list;

                    chartDayMonthSales.Series[1].Visible = true;
                    chartDayMonthSales.Series[0].Visible = false;

                    chartDayMonthSales.Show();
                    chartControlSalesVolumeMonthCategory.Hide();
                    chartControlSalesVolumeDayCategory.Hide();
                }
            }
        }

        private void ChildFormDailyMonthlySales_SizeChanged(object sender, EventArgs e)
        {
            chartControlSalesVolumeMonthCategory.Location = new Point(0,layoutControl.Height+9);
            
            chartControlSalesVolumeMonthCategory.Width = this.Size.Width;
            if (chartControlSalesVolumeMonthCategory.Width > 1600)
                chartControlSalesVolumeMonthCategory.Width -= (chartControlSalesVolumeMonthCategory.Width - 1600 );

            chartControlSalesVolumeMonthCategory.Height = this.Size.Height - layoutControl.Height - 9;
            //chartControlSalesVolumeMonthCategory.Dock = DockStyle.Bottom;

            chartDayMonthSales.Location = new Point(0, layoutControl.Height + 9);
            chartDayMonthSales.Width = this.Size.Width;
            if (chartDayMonthSales.Width > 1500)
                chartDayMonthSales.Width -= (chartDayMonthSales.Width - 1500);

            chartDayMonthSales.Height = this.Size.Height - layoutControl.Height - 9;
            //chartDayMonthSales.Dock = DockStyle.Bottom;

            chartControlSalesVolumeDayCategory.Location = new Point(0, layoutControl.Height + 9);
            chartControlSalesVolumeDayCategory.Width = this.Size.Width;
            if (chartControlSalesVolumeDayCategory.Width > 1600)
                chartControlSalesVolumeDayCategory.Width -= (chartControlSalesVolumeDayCategory.Width - 1600);

            chartControlSalesVolumeDayCategory.Height = this.Size.Height - layoutControl.Height - 9;
            //chartDayMonthSales.Dock = DockStyle.Bottom;
        }
    }
}
