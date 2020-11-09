using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace 화면설계
{
    //public class Product
    //{
    //    public string Name { get; set; }
    //    public string Category { get; set; }
    //    public string Distributor { get; set; }
    //    public string manufacture { get; set; }
    //    public int BuyPrice { get; set; }
    //    public int SellPrice { get; set; }
    //    public Product(string name, string category, string distributor, string manufacture, int buyPrice, int sellPrice)
    //    {
    //        this.Name = name;
    //        this.Category = category;
    //        this.Distributor = distributor;
    //        this.manufacture = manufacture;
    //        this.BuyPrice = buyPrice;
    //        this.SellPrice = sellPrice;

    //    }
    //}
    public class Distributor
    {
        public string Name { get; set; }
        public string ZipCode { get; set; }
        public string Addr { get; set; }
        public string AddrDetail { get; set; }
        public int Mobile1 { get; set; }
        public int Mobile2 { get; set; }
        public Distributor(string name, string zipcode, string addr, string addrDetail, int mobile1, int mobile2)
        {
            this.Name = name;
            this.ZipCode = zipcode;
            this.Addr = addr;
            this.AddrDetail = addrDetail;
            this.Mobile1 = mobile1;
            this.Mobile2 = mobile2;

        }
    }
    public class DistributorDB : IDisposable
    {

        MySqlConnection conn;
        string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        public DistributorDB()
        {
            conn = new MySqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public DataTable GetAllData()
        {
            DataTable dt = new DataTable();
            string sql = @"select distributor_no, distributor_name, mobile1, mobile2, zipcode, addr1, addr2,concat(mobile1,mobile2) mobile from distributor";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public bool Insert(Distributor dist)
        {
            string sql = @"insert into distributor (distributor_name, mobile1, mobile2, zipcode, addr1, addr2)
				                             values(@Name, @Mobile1, @Mobile2, @ZipCode, @Addr, @AddrDetail);";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            CommonUtil.AddParameter(cmd, "@Name", dist.Name);
            CommonUtil.AddParameter(cmd, "@Mobile1", dist.Mobile1, MySqlDbType.Int32);
            CommonUtil.AddParameter(cmd, "@Mobile2", dist.Mobile2, MySqlDbType.Int32);
            CommonUtil.AddParameter(cmd, "@ZipCode", dist.ZipCode);
            CommonUtil.AddParameter(cmd, "@Addr", dist.Addr);
            CommonUtil.AddParameter(cmd, "@AddrDetail", dist.AddrDetail);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
                return false;
            else
                return true;
        }

        public  bool Upadate(int dID, Distributor dist)
        {
            string sql = @"update distributor set distributor_name = @Name,
					                              mobile1 = @Mobile1,
                                                  mobile2 = @Mobile2,
                                                  zipcode = @ZipCode,
                                                  addr1 = @Addr,
                                                  addr2 = @AddrDetail
                       where distributor_no = @dID;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            CommonUtil.AddParameter(cmd, "@Name", dist.Name);
            CommonUtil.AddParameter(cmd, "@Mobile1", dist.Mobile1, MySqlDbType.Int32);
            CommonUtil.AddParameter(cmd, "@Mobile2", dist.Mobile2, MySqlDbType.Int32);
            CommonUtil.AddParameter(cmd, "@ZipCode", dist.ZipCode);
            CommonUtil.AddParameter(cmd, "@Addr", dist.Addr);
            CommonUtil.AddParameter(cmd, "@AddrDetail", dist.AddrDetail);
            CommonUtil.AddParameter(cmd, "@dID", dID, MySqlDbType.Int32);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
                return false;
            else
                return true;
        }

        public bool Delete(int dID)
        {
            string sql = "delete from distributor where distributor_no = @dID;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            CommonUtil.AddParameter(cmd, "@dID", dID, MySqlDbType.Int32);
            if (cmd.ExecuteNonQuery() == 0)
                return false;
            else
                return true;
        }
    }
}
