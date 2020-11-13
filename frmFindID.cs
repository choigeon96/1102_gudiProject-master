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
    public partial class frmFindID : Form
    {
        string result;
        public frmLogin login;
        public frmFindID()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                try
                {
                    EmpDB db = new EmpDB();
                    result = db.FindID(txtName.Text);
                    lblResult.Text = result;
                    db.Dispose();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
                MessageBox.Show("이름을 입력해주십시오.");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            login.ID = result;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmFindPassWord frm = new frmFindPassWord();
            frm.ShowDialog();
            this.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnSearch.PerformClick();
            }
        }
    }
}
