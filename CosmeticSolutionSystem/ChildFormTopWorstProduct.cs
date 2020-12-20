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
    public partial class ChildFormTopWorstProduct : Form
    {
        public ChildFormTopWorstProduct()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxTerm.Text.ToString() != CosmeticConstant.DateMonth
                && comboBoxTerm.Text.ToString() != CosmeticConstant.DateYear)
            {
                MessageBox.Show("기간을 다시 선택하세요", "오류");
                return;
            }

            int topCount = Convert.ToInt32(numericUpDownCount.Text);

            // 월을 선택하면
            if (comboBoxTerm.SelectedItem.ToString() == CosmeticConstant.DateMonth)
            {
                DateTime month = dateTimePicker.Value;
                //List<TopWorstProductModel> list = SalesDao.GetTopProductByMonth(month);
                List<TopWorstProductModel> list2 = SalesDao.GetTopProductByMonth(topCount, month);

                ChartHelper.ChangeChartTitle(chartPie, month.Year + "년" + month.Month + "월" + "TOP "+ topCount.ToString());
                chartControl1.Hide();
                chartPie.Show();

                //bindingSourceTopProduct.DataSource = list;
                bindingSourceTopProduct2.DataSource = list2;
            }
            else if (comboBoxTerm.SelectedItem.ToString() == CosmeticConstant.DateYear )
            {
                DateTime year = dateTimePicker.Value;
                //List<TopWorstProductModel> list = SalesDao.GetTopProductByYear(year);
                List<TopWorstProductModel> list2 = SalesDao.GetTopProductByYear(topCount, year);

                ChartHelper.ChangeChartTitle(chartPie, year.Year + "년" + "TOP " + topCount.ToString());

                chartControl1.Hide();
                chartPie.Show();
                bindingSourceTopProduct2.DataSource = list2;
            }
        }

        
        // 주를 선택하면 5주(1달 데이터를 출력)
        // 월을 선택하면 6개월 데이터를 출력
        // 년을 선택하면 3년 데이터를 출력
        private void ChildFormTopWorstProduct_Load(object sender, EventArgs e)
        {
            comboBoxTerm.Items.Add(CosmeticConstant.DateMonth);
            comboBoxTerm.Items.Add(CosmeticConstant.DateYear);

            comboBoxTerm.SelectedItem = "년";

            // 화면 로드 시 데이터를 조회한다
            dateTimePicker.Value = new DateTime(DateTime.Now.Year, 1, 1);

            btnSearch_Click(null, null);
        }

        private void ChildFormTopWorstProduct_SizeChanged(object sender, EventArgs e)
        {
            chartControl1.Width = this.Size.Width;
            chartControl1.Height = this.Size.Height - layoutControl1.Height - 9;
            chartControl1.Dock = DockStyle.Bottom;
            
            chartPie.Width = this.Size.Width;
            chartPie.Height = this.Size.Height - layoutControl1.Height - 9;
            chartPie.Dock = DockStyle.Bottom;
        }
    }
}
