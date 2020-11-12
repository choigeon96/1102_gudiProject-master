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
    public partial class frmLogin : Form
    {
        frmLogin frm;
        public string ID { set { this.txtID.Text = value; } }
        public string Password { set { this.txtPwd.Text = value; } }
        public LoginInfo GetLoginInfo
        {
            get { return new LoginInfo(txtID.Text, txtPwd.Text); }
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.Focus();
            lblID.Visible = true;
            lblPassword.Visible = true;
        }

        private void btnFindID_Click(object sender, EventArgs e)
        {
            frmFindID frm = new frmFindID();
            frm.login = this;
            frm.ShowDialog();
        }


        private void btnFindPwd_Click(object sender, EventArgs e)
        {
            frmFindPassWord frm = new frmFindPassWord();
            frm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EmpDB db = new EmpDB();
            string loginName = db.Login(this.GetLoginInfo);
            if (loginName == null)
            {
                MessageBox.Show("ID와 비밀번호를 확인해주세요");
            }
            else
            {
                this.Hide();
                frmMain frm = new frmMain(txtID.Text);
                frm.Text = loginName;
                frm.login = this;
                frm.Show();
            }
            db.Dispose();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin.PerformClick();
        }
    }
}
