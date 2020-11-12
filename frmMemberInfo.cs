using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 화면설계
{
    public partial class frmMemberInfo : Form
    {
        public DataRow MemberRow { get; set; }
        public int memberNo;
        bool lbxFlag = false;
        public frmMemberInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void frmMemberInfo_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lblDate.Text = DateTime.Now.ToLongDateString();
            CommonUtil.SetInitGridView(dgvSales);
            CommonUtil.AddGridTextColumn(dgvSales, "분류", "category", 80);
            CommonUtil.AddGridTextColumn(dgvSales, "제조사", "manufacture", 100);
            CommonUtil.AddGridTextColumn(dgvSales, "상품명", "product_name", 200);
            CommonUtil.AddGridTextColumn(dgvSales, "가격", "selling_price", 80);
            CommonUtil.AddGridTextColumn(dgvSales, "수량", "amount", 60);
            CommonUtil.AddGridTextColumn(dgvSales, "총액", "total", 80);
            CommonUtil.AddGridTextColumn(dgvSales, "메모", "memo", 150);
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmMemberSearch frm = new frmMemberSearch();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.memberNo = frm.MemberNo;
                GetMemberInfo(memberNo);
                lbxFlag =  GetVisitDate(memberNo);
                libVisitDate_SelectedIndexChanged(null, null);
                GetEyeTestInfo(memberNo);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmRegSales regSales = new frmRegSales();
            regSales.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmRegMember regMember = new frmRegMember();
            regMember.ShowDialog();
        }

        private void btnEyeTest_Click(object sender, EventArgs e)
        {
            frmNewEyeTest newEyeTest = new frmNewEyeTest(memberNo);
            if (newEyeTest.ShowDialog() == DialogResult.OK)
            {
                GetEyeTestInfo(memberNo);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            try
            {
                MemberDB db = new MemberDB();
                bool result = db.AddPoint(memberNo, Convert.ToInt32(txtAddPoint.Text));
                if (result)
                {
                    int newPoint = Convert.ToInt32(txtPoint.Text) + Convert.ToInt32(txtAddPoint.Text);
                    MessageBox.Show("추가되었습니다");
                    txtPoint.Text = newPoint.ToString();
                    txtAddPoint.Text = "";
                }
                db.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void btnSearchAddr_Click(object sender, EventArgs e)
        {
            AddrSerachPopup popup = new AddrSerachPopup();
            if (popup.ShowDialog() == DialogResult.OK)
            {
                txtAddr.Text = popup.Addr;
                txtZipCode.Text = popup.ZipCode;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MemberDB db = new MemberDB();
            try
            {
                MemberInfo member = new MemberInfo
                {
                    Name = lblName.Text,
                    Mobile1 = Convert.ToInt32(txtMobile1.Text),
                    Mobile2 = Convert.ToInt32(txtMobile2.Text),
                    ZipCode = txtZipCode.Text,
                    Addr = txtAddr.Text,
                    AddrDetail = txtAddrDetail.Text
                };
                bool result = db.Update(memberNo, member);
                if (result)
                {
                    MessageBox.Show("수정 성공");
                    GetMemberInfo(memberNo);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
            finally
            {
                db.Dispose();
            }
        }

        private void GetMemberInfo(int memberNo)
        {
            MemberDB db = new MemberDB();
            try
            {
                DataRow dr = db.GetMemberInfo(memberNo);
                lblName.Text = dr["member_name"].ToString();
                txtMemberName.Text = dr["member_name"].ToString();
                lblMemberNo.Text = dr["member_no"].ToString();
                txtPoint.Text = dr["point"].ToString();
                txtMobile1.Text = dr["mobile1"].ToString();
                txtMobile2.Text = dr["mobile2"].ToString();
                dtpBirth.Text = dr["birth_date"].ToString();
                txtZipCode.Text = dr["zipcode"].ToString();
                txtAddr.Text = dr["addr1"].ToString();
                txtAddrDetail.Text = dr["addr2"].ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            db.Dispose();
        }
        private bool GetVisitDate(int memberNo)
        {
            SalesDB db = new SalesDB();
            DataTable dt = new DataTable();
            try
            {
                dt = db.GetVisitDate(memberNo);
                libVisitDate.DataSource = dt;
                libVisitDate.DisplayMember = "sales_date";
                libVisitDate.ValueMember = "sales_date";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            db.Dispose();

            return dt.Rows.Count > 0 ? true : false;
        }

        private void libVisitDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxFlag)
            {
                SalesDB db = new SalesDB();
                try
                {
                    DataTable dt = db.GetSalesInfo(Convert.ToDateTime(libVisitDate.SelectedValue));
                    dgvSales.DataSource = dt;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                db.Dispose();
            }
        }

        private void GetEyeTestInfo(int memberNo)
        {
            EyeTestDB db = new EyeTestDB();
            try
            {
                DataSet ds = new DataSet();
                ds.Tables.Add(db.GetGlassesInfo(memberNo));
                ds.Tables[0].TableName = "glasses";
                ds.Tables.Add(db.GetLensInfo(memberNo));
                ds.Tables[1].TableName = "lens";

                DataRow glassOS = ds.Tables["glasses"].Rows[0];
                txtOSSPH.Text = glassOS["SPH"].ToString();
                txtOSCYL.Text = glassOS["CYL"].ToString();
                txtOSAXIS.Text = glassOS["AXIS"].ToString();
                txtOSFarPD.Text = glassOS["far_PD"].ToString();
                txtOSADD.Text = glassOS["ADD"].ToString();
                txtOSClosePD.Text = glassOS["close_PD"].ToString();
                txtOSOH.Text = glassOS["OH"].ToString();
                txtOSPRISM.Text = glassOS["PRISM"].ToString();

                DataRow glassOD = ds.Tables["glasses"].Rows[1];
                txtODSPH.Text = glassOD["SPH"].ToString();
                txtODCYL.Text = glassOD["CYL"].ToString();
                txtODAXIS.Text = glassOD["AXIS"].ToString();
                txtODFarPD.Text = glassOD["far_PD"].ToString();
                txtODADD.Text = glassOD["ADD"].ToString();
                txtODClosePD.Text = glassOD["close_PD"].ToString();
                txtODOH.Text = glassOD["OH"].ToString();
                txtODPRISM.Text = glassOD["PRISM"].ToString();

                DataRow lensOS = ds.Tables["lens"].Rows[0];
                txtOSCYL_L.Text = lensOS["CYL"].ToString();
                txtOSSPH_L.Text = lensOS["SPH"].ToString();
                txtOSADD_L.Text = lensOS["ADD"].ToString();
                txtOSBC.Text = lensOS["BC"].ToString();
                txtOSDIA.Text = lensOS["DIA"].ToString();
                txtOSKERATO.Text = lensOS["KERATO"].ToString();

                DataRow lensOD = ds.Tables["lens"].Rows[0];
                txtODCYL_L.Text = lensOD["CYL"].ToString();
                txtODSPH_L.Text = lensOD["SPH"].ToString();
                txtODADD_L.Text = lensOD["ADD"].ToString();
                txtODBC.Text = lensOD["BC"].ToString();
                txtODDIA.Text = lensOD["DIA"].ToString();
                txtODKERATO.Text = lensOD["KERATO"].ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            db.Dispose();
        }
    }
}
