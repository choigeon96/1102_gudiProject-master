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
    public class SalesDB : IDisposable
    {
        MySqlConnection conn;
        public SalesDB()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            conn.Open();
        }

        public DataTable GetVisitDate(int memberNo)
        {
            string sql = "select sales_no, sales_date from sales where member_no = @memberNo order by sales_date desc";
            MySqlDataAdapter da = new MySqlDataAdapter(sql,conn);
            da.SelectCommand.Parameters.Add("@memberNo", MySqlDbType.Int32);
            da.SelectCommand.Parameters["@memberNo"].Value = memberNo;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable GetSalesInfo(DateTime visitDate)
        {
            string sql = @"select  category, product_name, manufacture, sd.amount , selling_price,(sd.amount*selling_price) total, memo
                            from sales s join sales_detail sd on s.sales_no = sd.sales_no
                            			 join product p on sd.product_no = p.product_no
                            where s.sales_date = @visitDate;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql,conn);
            da.SelectCommand.Parameters.Add("@visitDate", MySqlDbType.Date);
            da.SelectCommand.Parameters["@visitDate"].Value = visitDate;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
