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
        public int MemberNo { get; set; }
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
            btnSearch.PerformClick();
        }

        private void UpdateText()
        {
            lblName.Text = MemberRow["member_name"].ToString();
            txtMemberName.Text = MemberRow["member_name"].ToString();
            lblMemberNo.Text = MemberRow["member_no"].ToString();
            txtPoint.Text = MemberRow["point"].ToString();
            txtMobile1.Text = MemberRow["mobile1"].ToString();
            txtMobile2.Text = MemberRow["mobile2"].ToString();
            dtpBirth.Text = MemberRow["birth_date"].ToString();
            txtZipCode.Text = MemberRow["zipcode"].ToString();
            txtAddr.Text = MemberRow["addr1"].ToString();
            txtAddrDetail.Text = MemberRow["addr2"].ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmMemberSearch frm = new frmMemberSearch();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.MemberRow = frm.Member;
                UpdateText();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmRegSales regSales = new frmRegSales();
            regSales.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmRegMember regMember = new frmRegMember();
            regMember.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmNewEyeTest newEyeTest = new frmNewEyeTest();
            newEyeTest.Show();
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
                bool result = db.AddPoint(Convert.ToInt32(lblMemberNo.Text), Convert.ToInt32(txtAddPoint.Text));
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
            int memberNo = Convert.ToInt32(lblMemberNo.Text);
            try
            {
                bool result = db.Update(MemberRow);
                if (result)
                {
                    MessageBox.Show("수정 성공");
                    GetMemberInfo(memberNo);
                    UpdateText();
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
            MemberRow = db.GetMemberInfo(memberNo);
        }
    }
}
