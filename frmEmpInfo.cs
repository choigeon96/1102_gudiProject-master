using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 화면설계
{
    public partial class frmEmpInfo : Form
    {
        public class EmpInfo
        {
            public string ID { get; }
            public string Name { get; }
            public string HireDate { get; }
            public string mobile1 { get; }
            public string mobile2 { get; }
            public string BirthDate { get; }
            public string Title { get; }
            public string Password { get; }
            public string PostalCode { get; }
            public string Addr { get; }
            public string AddrDetail { get; }
            public string Email { get; }
            public EmpInfo(frmEmpInfo frm)
            {
                this.ID = frm.txtEmpID.Text;
                this.Name = frm.txtEmpName.Text;
                this.HireDate = frm.dtpHireDate.Text;
                this.mobile1 = frm.txtMobile1.Text;
                this.mobile2 = frm.txtMobile2.Text;
                this.BirthDate = frm.dtpBirthDate.Text;
                this.Title = frm.cmbTitle.Text;
                this.Password = frm.txtPwd.Text;
                this.PostalCode = frm.txtPostalCode.Text;
                this.Addr = frm.txtAddr.Text;
                this.AddrDetail = frm.txtAddrDetail.Text;
                this.Email = frm.txtEmail.Text;
            }
        }
        DataTable dt;
        public frmEmpInfo()
        {
            InitializeComponent();
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }
        private void frmEmpInfo_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvEmpInfo);
            CommonUtil.AddGridTextColumn(dgvEmpInfo, "이름", "emp_name", 60);
            CommonUtil.AddGridTextColumn(dgvEmpInfo, "전화번호", "mobile", 100, true, DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgvEmpInfo, "업무", "title", 60, true);
            dtpHireDate.Format = DateTimePickerFormat.Short;
            dtpHireDate.Enabled = false;
            txtPostalCode.Enabled = false;
            LoadData();
        }

        private void LoadData()
        {
            EmpDB db = new EmpDB();
            try
            {
                dt = db.GetAllData();
                dgvEmpInfo.DataSource = dt;
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
        private void PrintEmpDetail(object sender, DataGridViewCellEventArgs e)
        {

            txtEmpID.Text = dt.Rows[e.RowIndex]["emp_ID"].ToString();
            txtPwd.Text = dt.Rows[e.RowIndex]["password"].ToString();
            txtEmpName.Text = dt.Rows[e.RowIndex]["emp_name"].ToString();
            dtpBirthDate.Value = Convert.ToDateTime(dt.Rows[e.RowIndex]["birth_date"]);
            dtpHireDate.Value = Convert.ToDateTime(dt.Rows[e.RowIndex]["hire_date"]);
            txtMobile1.Text = dt.Rows[e.RowIndex]["mobile1"].ToString();
            txtMobile2.Text = dt.Rows[e.RowIndex]["mobile2"].ToString();
            cmbTitle.Text = dt.Rows[e.RowIndex]["title"].ToString();
            txtPostalCode.Text = dt.Rows[e.RowIndex]["addr1"].ToString();
            txtAddr.Text = dt.Rows[e.RowIndex]["addr2"].ToString();
            txtAddrDetail.Text = dt.Rows[e.RowIndex]["addr3"].ToString();
            txtEmail.Text = dt.Rows[e.RowIndex]["email"].ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StringBuilder sb = IsValid();

            if (sb.Length > 0)
                MessageBox.Show(sb.ToString());
            else
            {
                //DB에 등록
                EmpInfo emp = new EmpInfo(this);
                EmpDB db = new EmpDB();
                try
                {
                    db.Insert(emp);
                    MessageBox.Show("등록 성공");
                    ClearControls();
                    LoadData();
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

        private StringBuilder IsValid()
        {
            StringBuilder sb = new StringBuilder();
            //유효성 체크
            if (txtEmpID.TextLength < 4)
                sb.AppendLine("4글자 이상의 ID를 입력해 주십시오.");
            if (txtPwd.TextLength < 6)
                sb.AppendLine("6글자 이상의 비밀번호를 입력해 주십시오.");
            if (string.IsNullOrEmpty(txtEmpName.Text))
                sb.AppendLine("이름을 입력해 주십시오.");
            if ((DateTime.Now.Year - dtpBirthDate.Value.Year) < 19)
                sb.AppendLine("생년월일을 확인해 주십시오.");
            if (string.IsNullOrEmpty(txtAddr.Text))
                sb.AppendLine("주소를 선택해 주십시오.");
            if (string.IsNullOrEmpty(txtAddrDetail.Text))
                sb.AppendLine("상세주소를 입력해 주십시오");

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(txtEmail.Text);
            if (!match.Success)
                sb.AppendLine("잘못된 email입니다.");
            return sb;
        }

        private void ClearControls()
        {
            foreach (Control item in panControls.Controls)
            {
                item.Text = default;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void txtAddrDetail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //유효성 체크
            StringBuilder sb = IsValid();

            if (sb.Length > 0)
                MessageBox.Show(sb.ToString());
            else
            {
                //DB에 수정
                EmpInfo emp = new EmpInfo(this);
                EmpDB db = new EmpDB();
                try
                {
                    db.Update(emp);
                    MessageBox.Show("수정 성공");
                    ClearControls();
                    LoadData();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EmpDB db = new EmpDB();
                try
                {
                    bool result = db.Delete(txtEmpID.Text);
                    if (result)
                        MessageBox.Show("삭제 성공");
                    else
                        MessageBox.Show("다시 시도해 주십시오.");
                    ClearControls();
                    LoadData();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
