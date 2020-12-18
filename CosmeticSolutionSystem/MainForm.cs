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
    public partial class MainForm : Form
    {
        private Dictionary<string, Form> childformDict = new Dictionary<string, Form>();
        List<Form> childformList = new List<Form>();
        List<string> childformNameList = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 프레임 윈도우 관리를 위해 Key/Value, 생성된 순서대로의 자료구조를 만든다
        /// </summary>
        /// <param name="keyString"></param>
        /// <param name="_form"></param>
        private void RegisterChildForm(string keyString, Form _form)
        {
            childformDict.Add(keyString, _form);
            childformList.Add(_form);
            childformNameList.Add(keyString);
            _form.MdiParent = this;
            _form.Show();
        }

        private void ShowChildForm(string key)
        {
            childformDict[key].MdiParent = this;
            childformDict[key].Show();
            childformDict[key].Activate();
        }

        /// <summary>
        /// 메인 폼이 로드될 때 차일드 프레임을 생성한다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Form form = null;

            // 1. 손익 계산서 화면
            form = new ChildFormIncomeStatement();
            RegisterChildForm("ChildFormIncomeStatement", form);

            // 2. 손익 계산서 화면
            form = new ChildFormBalanceSheet();
            RegisterChildForm("ChildFormBalanceSheet", form);

            // 3. 일별/월별 판매량
            form = new ChildFormDailyMonthlySales();
            RegisterChildForm("ChildFormDailyMonthlySales", form);

            // 4. 시간대별 고객 구매자 수 분석
            form = new ChildFormHourlySales();
            RegisterChildForm("ChildFormHourlySales", form);

            // 5. 코로나 확진자 수에 따른 카테고리별 판매량
            form = new ChildFormSalesCategorizedByConfirmedCOVID19Cases();
            RegisterChildForm("ChildFormSalesCategorizedByConfirmedCOVID19Cases", form);

            // 6. 카테고리별 연령대별 비중 남자 - 여자
            form = new ChildFormCategorizedByAgeGroup();
            RegisterChildForm("ChildFormCategorizedByAgeAndGenderGroup", form);

            // 7. 비건 화장품 매출
            form = new ChildFormSalesOfVeganCosmetic();
            RegisterChildForm("ChildFormSalesOfVeganCosmetic", form);

            // 8. 브랜드별 최근 1년 월 매출
            form = new ChildFormRecentYearlySalesBasedOnBrand();
            RegisterChildForm("ChildFormRecentYearlySalesBasedOnBrand", form);

            // 9. Top / Worst 5 제품
            form = new ChildFormTopWorstProduct();
            RegisterChildForm("ChildFormTopWorstProduct", form);

            ShowChildForm(childformNameList[0]);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(childformNameList[0]);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(childformNameList[1]);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(childformNameList[2]);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(childformNameList[3]);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(childformNameList[4]);
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(childformNameList[5]);
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(childformNameList[6]);
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(childformNameList[7]);
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(childformNameList[8]);
        }
    }
}
