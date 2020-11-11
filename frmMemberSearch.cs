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
    public partial class frmMemberSearch : Form
    {
        DataTable dt;
        public int MemberNo { get; set; }
        public frmMemberSearch()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMemberSearch_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvMember);
            CommonUtil.AddGridTextColumn(dgvMember, "no", "member_no", 40);
            CommonUtil.AddGridTextColumn(dgvMember, "이름", "member_name", 60);
            CommonUtil.AddGridTextColumn(dgvMember, "전화번호", "mobile", 80);
            CommonUtil.AddGridTextColumn(dgvMember, "생년월일", "birth_date", 100);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length < 1)
                MessageBox.Show("검색할 이름을 입력하세요.");
            else
            {
                MemberDB db = new MemberDB();
                try
                {
                   dt = db.Search(txtName.Text);
                    if (dt.Rows.Count < 1)
                        MessageBox.Show("검색된 결과가 없습니다.");
                    else
                        dgvMember.DataSource = dt;
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            MemberNo = Convert.ToInt32(dgvMember[0, dgvMember.CurrentRow.Index].Value);
            MessageBox.Show(MemberNo.ToString());
            this.DialogResult = DialogResult.OK;
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
