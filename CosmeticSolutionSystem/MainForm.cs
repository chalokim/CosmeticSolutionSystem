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
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<string, Form> formDict = new Dictionary<string, Form>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ViewChild(Form _form)
        {
            if (_form == null)
                return;

            _form.MdiParent = this;
            _form.Show();
            _form.Activate();
        }

        /// <summary>
        /// 차트 화면을 생성하고 Dictionary 자료구조에 
        /// Key, Value로 저장한다
        /// 9개 화면을 보여주고 첫 번째 화면을 활성화시킨다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // 1. 손익 계산서
            IncomeStatementChildForm incomeStatementChildForm = new IncomeStatementChildForm();
            incomeStatementChildForm.MdiParent = this;
            formDict.Add("incomeStatementChildForm", incomeStatementChildForm);
            incomeStatementChildForm.Show();

            // 2. 재무 상태표
            BalanceSheetChildForm balanceSheetChildForm = new BalanceSheetChildForm();
            balanceSheetChildForm.MdiParent = this;
            formDict.Add("balanceSheetChildForm", balanceSheetChildForm);
            balanceSheetChildForm.Show();

            // 3. 일/월별 판매량
            MonthlyDailySalesVolume monthlyDailySalesVolume = new MonthlyDailySalesVolume();
            monthlyDailySalesVolume.MdiParent = this;
            formDict.Add("monthlyDailySalesVolume", monthlyDailySalesVolume);
            monthlyDailySalesVolume.Show();

            // 4. 시간대별 고객 구매자 수
            BuyerNumberByTimeSlot buyerNumberByTimeSlot = new BuyerNumberByTimeSlot();
            buyerNumberByTimeSlot.MdiParent = this;
            formDict.Add("buyerNumberByTimeSlot", buyerNumberByTimeSlot);
            buyerNumberByTimeSlot.Show();

            // 5. 코로나 확진자 수에 따른 카테고리별 판매량
            CategorySalesVolumeByCoronaPatientNumber categorySalesVolumeByCoronaPatientNumber = new CategorySalesVolumeByCoronaPatientNumber();
            categorySalesVolumeByCoronaPatientNumber.MdiParent = this;
            formDict.Add("categorySalesVolumeByCoronaPatientNumber", categorySalesVolumeByCoronaPatientNumber);
            categorySalesVolumeByCoronaPatientNumber.Show();

            // 6. 카테고리 연령대별 매출 비중
            SalesWeightByCategoryAndAgeGroup salesWeightByCategoryAndAgeGroup = new SalesWeightByCategoryAndAgeGroup();
            salesWeightByCategoryAndAgeGroup.MdiParent = this;
            formDict.Add("salesWeightByCategoryAndAgeGroup", salesWeightByCategoryAndAgeGroup);
            salesWeightByCategoryAndAgeGroup.Show();

            // 7. 비건 화장품 매출
            VeganCosmeticsSalesVolume veganCosmeticsSalesVolume = new VeganCosmeticsSalesVolume();
            veganCosmeticsSalesVolume.MdiParent = this;
            formDict.Add("veganCosmeticsSalesVolume", veganCosmeticsSalesVolume);
            veganCosmeticsSalesVolume.Show();

            // 8. 브랜드별 최근 매출(1년, 월)
            SalesVolumeByBrand salesVolumeByBrand = new SalesVolumeByBrand();
            salesVolumeByBrand.MdiParent = this;
            formDict.Add("salesVolumeByBrand", salesVolumeByBrand);
            salesVolumeByBrand.Show();

            // 9. Top / Worst 5  상품
            TopWorstProduct topWorstProduct = new TopWorstProduct();
            topWorstProduct.MdiParent = this;
            formDict.Add("topWorstProduct", topWorstProduct);
            topWorstProduct.Show();

            ViewChild(incomeStatementChildForm);
        }

        // 손익 계산서
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewChild(formDict["incomeStatementChildForm"]);
        }

        // 재무 상태표
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewChild(formDict["balanceSheetChildForm"]);
        }

        // 일/월별 판매량
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewChild(formDict["monthlyDailySalesVolume"]);
        }

        // 시간대별 구매자수
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewChild(formDict["buyerNumberByTimeSlot"]);
        }

        // 코로나 확진자 수에 따른 카테고리별 판매량
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewChild(formDict["categorySalesVolumeByCoronaPatientNumber"]);
        }

        // 카테고리 연령대별 매출 비중
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewChild(formDict["salesWeightByCategoryAndAgeGroup"]);
        }

        // 비건 화장품 매출
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewChild(formDict["veganCosmeticsSalesVolume"]);
        }

        // 브랜드별 최근 매출(1년, 월)
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewChild(formDict["salesVolumeByBrand"]);
        }

        // Top / Worst 5  상품
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewChild(formDict["topWorstProduct"]);
        }
    }
}
