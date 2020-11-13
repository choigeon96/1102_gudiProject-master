using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace 화면설계
{
    public class MemberInfo
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Job { get; set; }
        public string Email { get; set; }
        public string ZipCode { get; set; }
        public string Addr { get; set; }
        public string AddrDetail { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public DateTime Birth { get; set; }
    }
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
            string sql = @"insert into member (member_name, gender, mobile1, mobile2, job,  reg_date, zipcode, addr1, addr2, birth_date)
                                        values(@Name, @Gender, @Mobile1, @Mobile2, @Job, @reg_date, @ZipCode, @Addr, @Addrdetail, @birth_date)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            CommonUtil.AddParameter(cmd, "@Name", member.Name);
            CommonUtil.AddParameter(cmd, "@Gender", member.Gender);
            CommonUtil.AddParameter(cmd, "@Mobile1", member.Mobile1);
            CommonUtil.AddParameter(cmd, "@Mobile2", member.Mobile2);
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
            string sql = "select member_no, member_name, gender, mobile1, mobile2, job, point, reg_date, zipcode, addr1, addr2, birth_date, concat(mobile1, mobile2) mobile from member where member_name = @name";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            CommonUtil.AddParameter(da.SelectCommand, "@name", name);
            da.Fill(dt);
            return dt;

        }

        public bool AddPoint(int memberNo, int addPoint)
        {
            string sql = "update  member set point = point + @addPoint where member_no = @memberNo;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            CommonUtil.AddParameter(cmd, "@addPoint", addPoint, MySqlDbType.Int32);
            CommonUtil.AddParameter(cmd, "@memberNo", memberNo, MySqlDbType.Int32);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
                return false;
            else
                return true;
        }

        public bool Update(int memberNo, MemberInfo member)
        {
            string sql = @"update member set member_name = @member_name,
                                                  mobile1 = @mobile1,
                           					      mobile2 = @mobile2,
                                                  zipcode = @zipcode,
                                                  addr1 = @addr1,
                                                  addr2 = @addr2
                           where member_no = @memberNo";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            CommonUtil.AddParameter(cmd, "@member_name", member.Name);
            CommonUtil.AddParameter(cmd, "@mobile1", member.Mobile1);
            CommonUtil.AddParameter(cmd, "@mobile2", member.Mobile2);
            CommonUtil.AddParameter(cmd, "@zipcode", member.ZipCode);
            CommonUtil.AddParameter(cmd, "@addr1", member.Addr);
            CommonUtil.AddParameter(cmd, "@addr2", member.AddrDetail);
            CommonUtil.AddParameter(cmd, "@memberNo", memberNo, MySqlDbType.Int32);
            int result = cmd.ExecuteNonQuery();
            return result == 0 ? false : true;
        }

        public DataRow GetMemberInfo(int memberNo)
        {
            string sql = "select member_no, member_name, gender, mobile1, mobile2, job, point, zipcode, addr1, addr2, birth_date from member where member_no = @memberNo;";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            CommonUtil.AddParameter(da.SelectCommand, "@memberNo", memberNo);
            da.Fill(dt);
            DataRow dr = dt.Rows[0];
            return dr;

        }
    }
}
