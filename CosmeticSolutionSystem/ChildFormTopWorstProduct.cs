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

            // 월을 선택하면
            if (comboBoxTerm.SelectedItem.ToString() == CosmeticConstant.DateMonth)
            {
                DateTime month = dateTimePicker.Value;
                List<TopWorstProductModel> list = SalesDao.GetTopProductByMonth(month);

                bindingSourceTopProduct.DataSource = list;
            }
            else if (comboBoxTerm.SelectedItem.ToString() == CosmeticConstant.DateYear )
            {
                DateTime year = dateTimePicker.Value;
                List<TopWorstProductModel> list = SalesDao.GetTopProductByYear(year);

                bindingSourceTopProduct.DataSource = list;
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
    }
}
