using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;
namespace 화면설계
{
    public partial class frmFindPassWord : Form
    {
        private string newPwd;
        public frmFindPassWord()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmFindPassWord_Load(object sender, EventArgs e)
        {
            btnChange.Enabled = false;
            txtPassword.Enabled = false;
            txtPasswordCheck.Enabled = false;
            txtNumber.Enabled = false;
            btnCheck.Enabled = false;

        }

        private void EnableChange()
        {
            btnChange.Enabled = !btnChange.Enabled;
            txtPassword.Enabled = !txtPassword.Enabled;
            txtPasswordCheck.Enabled = !txtPasswordCheck.Enabled;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"); 
            Match match = regex.Match(txtEmail.Text);

            if (!match.Success)
            {
                MessageBox.Show("잘못된 emil입니다.");
                return;
            }
            EmpDB db = new EmpDB();
            try
            {
                bool result = db.CheckIDAndMail(txtID.Text, txtEmail.Text);
                if (!result)
                    MessageBox.Show("잘못 입력하셨습니다.");
                else
                {
                    txtID.Enabled = false;
                    txtEmail.Enabled = false;
                    txtNumber.Enabled = true;
                    btnCheck.Enabled = true;
                }
                newPwd = SendMail(txtEmail.Text , txtID.Text);
                MessageBox.Show(newPwd.ToString());
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

        private string SendMail(string email, string id)
        {
            Random rand = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                int val = rand.Next(0, 36); //0~35 (0~9=>숫자, 10~35=>영문자)
                if (val < 10)              //숫자
                    sb.Append(val);
                else                       //영문대문자 (65~90)
                    sb.Append((char)(val + 55));
            }
            
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.UseDefaultCredentials = false; //시스템에 설정된 인증 정보를 사용하지 않는다.
                client.EnableSsl = true; //SSL을 사용한다.
                client.DeliveryMethod = SmtpDeliveryMethod.Network; //Gmail 인증
                client.Credentials = new NetworkCredential("choigeon96", "c36069848");

                MailAddress mailTo = new MailAddress(email);
                MailAddress mailFrom = new MailAddress("admin@choigeon96.com");

                MailMessage message = new MailMessage(mailFrom, mailTo);
                message.Subject = $"{id}님의 비밀번호 변경을 위한 본인 인증 메일입니다.";
                message.Body = $"{id}님의 인증번호는 {sb.ToString()}입니다.";
                message.BodyEncoding = Encoding.UTF8;
                message.SubjectEncoding = Encoding.UTF8;

                client.Send(message);

                return sb.ToString();
            }
            catch (Exception err)
            {
                return null;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            if (txtNumber.Text.Length != 8)
            {
                MessageBox.Show("8자리의 인증번호를 입력하세요.");
                return;
            }
            if (txtNumber.Text == newPwd.ToString())
            {
                EnableChange();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordCheck.Text)
            {
                MessageBox.Show("같은 비밀번호를 입력하세요.");
                return;
            }
            EmpDB db = new EmpDB();
            try
            {
                if (db.UpdatePwd(txtID.Text, txtPassword.Text))
                    MessageBox.Show("수정되었습니다.");
                this.Close();
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
}
