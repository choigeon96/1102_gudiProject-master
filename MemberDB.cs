using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 화면설계
{
    public class MemberDB:IDisposable
    {
        MySqlConnection conn;
        public MemberDB()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public bool Insert(MemberInfo member)
        {
            string sql = @"insert into member (member_name, gender, mobile1, mobile2, job,  reg_date, zipcode, addr2, addr3)
                                        values(@Name, @Gender, @Mobile1, @Mobile2, @Job, @reg_date, @ZipCode, @Addr, @Addrdetail, @birth_date)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            CommonUtil.AddParameter(cmd, "@Name", member.Name);
            CommonUtil.AddParameter(cmd, "@Gender", member.Gender);
            CommonUtil.AddParameter(cmd, "@Mobile1", member.Mobile1,MySqlDbType.Int32);
            CommonUtil.AddParameter(cmd, "@Mobile2", member.Mobile2, MySqlDbType.Int32);
            CommonUtil.AddParameter(cmd, "@Job", member.Job);
            CommonUtil.AddParameter(cmd, "@reg_date", DateTime.Now,MySqlDbType.Date);
            CommonUtil.AddParameter(cmd, "@birth_date", member.Birth,MySqlDbType.Date);
            CommonUtil.AddParameter(cmd, "@ZipCode", member.ZipCode);
            CommonUtil.AddParameter(cmd, "@Addr", member.Addr);
            CommonUtil.AddParameter(cmd, "@Addrdetail", member.AddrDetail);
            int rRow = cmd.ExecuteNonQuery();

            return rRow == 0 ? false : true;
        }

        public DataTable Search(string name)
        {
            DataTable dt = new DataTable();
            string sql = "select member_no, member_name ,concat(mobile1, mobile2) mobile, birth_date from member where member_name = @name";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            CommonUtil.AddParameter(da.SelectCommand, "@name", name);
            da.Fill(dt);
            return dt;

        }
    }
}
