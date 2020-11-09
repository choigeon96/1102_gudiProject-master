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
        

        public void Dispose()
        {
            conn.Close();
        }


    }
}
