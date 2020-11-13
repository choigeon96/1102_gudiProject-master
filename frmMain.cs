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
    public partial class frmMain : Form
    {
        frmMemberInfo frmMember;
        static string empID;
        static public string EmpID { get { return empID; } }
        public frmLogin login;
        public frmMain(string empID)
        {
            InitializeComponent();
            frmMain.empID = empID;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmMemberInfo memberForm = new frmMemberInfo();
            memberForm.MdiParent = this;
            memberForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSales FrmSales = new frmSales();
            FrmSales.MdiParent = this;
            FrmSales.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void 통계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraph graph = new frmGraph();
            graph.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("로그아웃 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                login.Show();
                login.ID = "";
                login.Password = "";
                this.Close();
            }
        }

        private void btnNewSales_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 직원관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpInfo frm = new frmEmpInfo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule frm = new Schedule();
            frm.Show();
        }

        private void btnRegProduct_Click(object sender, EventArgs e)
        {
            frmRegProduct frm = new frmRegProduct();
            frm.Show();
        }

        private void btnMemberInfo_Click(object sender, EventArgs e)
        {
            
            frmMember = new frmMemberInfo();
            frmMember.MdiParent = this;
            frmMember.Show();

        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            frmRegMember frm = new frmRegMember();
            frm.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Close();
        }
    }
}
