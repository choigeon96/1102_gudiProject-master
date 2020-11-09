using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;
using System.Security.Authentication;

namespace 화면설계
{
    public class LoginInfo
    {
        public string ID;
        public string Password;
        public LoginInfo(string id, string password)
        {
            this.ID = id;
            this.Password = password;
        }
    }

    class EmpDB : IDisposable
    {
        MySqlConnection conn;
        string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        public EmpDB()
        {
            conn = new MySqlConnection(strConn);
            conn.Open();
        }

        public DataTable GetEmpName()
        {
            DataTable dt = new DataTable();
            string sql = "select emp_Name from employees";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public string FindID(string empName)
        {
            string sql = "select emp_ID from employees where emp_name= @emp_name";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.Parameters.Add("@emp_name", MySqlDbType.VarChar);
            cmd.Parameters["@emp_name"].Value = empName;
            string result = (string)cmd.ExecuteScalar();
            if (string.IsNullOrEmpty(result))
                throw new Exception("검색된 내용이 없습니다.");
            return result;
        }

        public bool CheckIDAndMail(string empID, string email)
        {
            string sql = "select count(*) from employees where emp_ID = @emp_ID and email = @email";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@emp_ID", MySqlDbType.VarChar);
            cmd.Parameters["@emp_ID"].Value = empID;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar);
            cmd.Parameters["@email"].Value = email;
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                return true;
            else
                return false;
        }

        public DataTable GetSchedule(DateTime date)
        {
            DataTable dt = new DataTable();
            string sql = "select emp_name from schedule s inner join employees e on s.emp_ID = e.emp_ID where work_date = @work_date;";
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@work_date", MySqlDbType.Date);
                da.SelectCommand.Parameters["@work_date"].Value = date;
                da.Fill(dt);
                return dt;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public string Login(LoginInfo info)
        {
            string sql = "select count(*) from employees where emp_ID = @emp_ID and password = @password;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.Add("@emp_ID", MySqlDbType.VarChar);
            cmd.Parameters["@emp_ID"].Value = info.ID;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar);
            cmd.Parameters["@password"].Value = info.Password;
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "select emp_name from employees where emp_ID = @emp_ID";
                cmd.Parameters.Add("@emp_ID", MySqlDbType.VarChar);
                cmd.Parameters["@emp_ID"].Value = info.ID;
                return cmd.ExecuteScalar().ToString();
            }
            else
                return null;

        }

        public bool Insert(frmEmpInfo.EmpInfo emp)
        {
            string sql = @"insert into employees (emp_ID, emp_name, hire_date, mobile1, mobile2, birth_date, title, password, addr1, addr2, addr3, email)
                                           values(@emp_ID, @emp_name, @hire_date, @mobile1, @mobile2, @birth_date, @title, @password, @addr1, @addr2, @addr3, @email)";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                SetParameterInsUp(emp, cmd);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool InsertSchedule(DateTime date, CheckedListBox.CheckedItemCollection checkedList)
        {

            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"delete from schedule where work_date = @work_date";
                MySqlCommand delSchedule = new MySqlCommand(sql, conn);
                delSchedule.Parameters.Add("@work_date", MySqlDbType.Date);
                delSchedule.Parameters["@work_date"].Value = date;
                delSchedule.Transaction = trans;
                delSchedule.ExecuteNonQuery();
                sql = @"insert into schedule (work_date, emp_ID)
                                             values (@work_date, (select emp_ID from employees where emp_name = @emp_Name))";
                MySqlCommand cmdNewSchedule = new MySqlCommand(sql, conn);
                CommonUtil.AddParameter(cmdNewSchedule, "@work_date", date, MySqlDbType.Date);
                cmdNewSchedule.Parameters.Add("@emp_Name", MySqlDbType.VarChar);
                cmdNewSchedule.Transaction = trans;

                foreach (string item in checkedList)
                {
                    cmdNewSchedule.Parameters["@emp_Name"].Value = item.ToString();
                    if (cmdNewSchedule.ExecuteNonQuery() == 0)
                        return false;
                }

                trans.Commit();
                return true;
            }
            catch (Exception err)
            {
                trans.Rollback();
                throw err;
            }
        }

        public bool UpdatePwd(string empID, string newPwd)
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "update employees set password = @password where emp_ID = @emp_ID";
                cmd.Parameters.Add("@password", MySqlDbType.VarChar);
                cmd.Parameters.Add("@emp_ID", MySqlDbType.VarChar);
                cmd.Parameters["@password"].Value = newPwd;
                cmd.Parameters["@emp_ID"].Value = empID;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        public bool Update(frmEmpInfo.EmpInfo emp)
        {
            string sql = @"update employees set emp_name = @emp_name,
                                                hire_date = @hire_date,
                                                mobile1 = @mobile1,
                                                mobile2 = @mobile2,
                                                birth_date = @birth_date,
                                                title = @title,
                                                password = @password,
                                                addr1 = @addr1,
                                                addr2 = @addr2,
                                                addr3 = @addr3,
                                                email = @email
                            where emp_ID = @emp_ID";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                SetParameterInsUp(emp, cmd);
                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                    return false;
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private void SetParameterInsUp(frmEmpInfo.EmpInfo emp, MySqlCommand cmd)
        {
            CommonUtil.AddParameter(cmd, "@emp_ID", emp.ID);
            CommonUtil.AddParameter(cmd, "@emp_name", emp.Name);
            CommonUtil.AddParameter(cmd, "@hire_date", emp.HireDate);
            CommonUtil.AddParameter(cmd, "@mobile1", emp.mobile1);
            CommonUtil.AddParameter(cmd, "@mobile2", emp.mobile2);
            CommonUtil.AddParameter(cmd, "@birth_date", emp.BirthDate);
            CommonUtil.AddParameter(cmd, "@title", emp.Title);
            CommonUtil.AddParameter(cmd, "@password", emp.Password);
            CommonUtil.AddParameter(cmd, "@addr1", emp.PostalCode);
            CommonUtil.AddParameter(cmd, "@addr2", emp.Addr);
            CommonUtil.AddParameter(cmd, "@addr3", emp.AddrDetail);
            CommonUtil.AddParameter(cmd, "@email", emp.Email);
        }

        public bool Delete(string EmpID)
        {
            string sql = @"delete from employees where emp_ID = @emp_ID";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                CommonUtil.AddParameter(cmd, "@emp_ID", EmpID);
                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                    return false;
                return true;
            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public DataTable GetAllData()
        {
            string sql = @"select emp_ID, emp_name, hire_date,concat(mobile1,mobile2) mobile, mobile1, mobile2, birth_date, title, password, addr1, addr2, addr3, email
                            from employees;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            try
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

            catch (Exception err)
            {
                throw err;
            }
        }
        public void Dispose()
        {
            conn.Close();
        }
    }
}
