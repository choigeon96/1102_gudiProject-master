using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Data;

namespace 화면설계
{
    public class CodeDB : IDisposable
    {
        MySqlConnection conn;
        string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        public CodeDB()
        {
            conn = new MySqlConnection(strConn);
            conn.Open();
        }


        public DataSet GetCommonCode(string[] categorys)
        {
            string sql = @"select name,code from commoncode where category = @category order by category";
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.Add("@category", MySqlDbType.VarChar);
            foreach (string category in categorys)
            {
                da.SelectCommand.Parameters["@category"].Value = category;
                da.Fill(ds, category);
            }
            return ds;
        }
        public Dictionary<string, string> GetCategory()
        {
            Dictionary<string, string> codeList = new Dictionary<string, string>();
            string sql = @"select name from commoncode where category = '상품분류'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                codeList.Add(reader[0].ToString(), reader[0].ToString());
            }
            return codeList;
        }

        internal List<string> GetDistributor()
        {
            List<string> codeList = new List<string>();
            string sql = @"select name from commoncode where category = '거래처'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                codeList.Add(reader[0].ToString());
            }
            return codeList;
        }

        public List<string> GetManufacturer()
        {
            List<string> codeList = new List<string>();
            string sql = @"select name from commoncode where category = '제조사'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                codeList.Add(reader[0].ToString());
            }
            return codeList;
        }

        public void Dispose()
        {
            conn.Close();
        }


    }
}
