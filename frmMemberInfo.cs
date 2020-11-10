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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmMemberSearch frm = new frmMemberSearch();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.memberNo = frm.MemberNo;
                GetMemberInfo(memberNo);
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
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            db.Dispose();
        }
    }
}
