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
    public partial class frmRegMember : Form
    {
        public frmRegMember()
        {
            InitializeComponent();
        }

        private void btnAddrSearch_Click(object sender, EventArgs e)
        {
            AddrSerachPopup popup = new AddrSerachPopup();
            if(popup.ShowDialog() == DialogResult.OK)
            {
                txtAddr.Text = popup.Addr;
                txtZipCode.Text = popup.ZipCode;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MemberInfo member = new MemberInfo
            {
                Name = txtName.Text,
                Gender = cmbGender.Text,
                Job = cmbJob.Text,
                ZipCode = txtZipCode.Text,
                Addr = txtAddr.Text,
                AddrDetail = txtAddrDetail.Text,
                Mobile1 = Convert.ToInt32(txtMobile1.Text),
                Mobile2 = Convert.ToInt32(txtMobile2.Text),
                Birth = dtpBirth.Value
            };
            MemberDB db = new MemberDB();
            try
            {
                bool result = db.Insert(member);
                if (result)
                {
                    MessageBox.Show("등록 성공");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("다시 시도하여 주십시오");
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

        private void frmRegMember_Load(object sender, EventArgs e)
        {
            CodeDB code = new CodeDB();
            string[] codes = { "성별", "직업"};
            DataSet ds = code.GetCommonCode(codes);
            CommonUtil.BindingComboBox(cmbGender, ds.Tables["성별"], "code", "name");
            CommonUtil.BindingComboBox(cmbJob, ds.Tables["직업"], "code", "name");
            code.Dispose();
        }
    }
    
}
