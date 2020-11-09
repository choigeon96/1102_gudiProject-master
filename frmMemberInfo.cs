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
            this.WindowState=FormWindowState.Maximized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMemberSearch search = new frmMemberSearch();
            search.Show();
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
    }
}
