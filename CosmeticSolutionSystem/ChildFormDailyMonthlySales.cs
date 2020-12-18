using CosmeticSolutionSystem.Data;
using CosmeticSolutionSystem.Data.Models;
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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 설정된 조건으로 검색한다
            Button btn = sender as Button;
            if (btn == null)
                return;

            // 월을 선택하면
            if (comboBoxInterval.SelectedItem.ToString() == CosmeticConstant.DateMonth)
            {
                DateTime month = dateTimePicker.Value;
                List<DayMonthSalesModel> list = SalesDao.GetSalesVolumeByMonth(month);

                bindingSourceMonthDaySales.DataSource = list;
            }
        }
    }
}
