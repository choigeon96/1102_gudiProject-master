using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace 화면설계
{
    public class Product{
        public string Name{ get; set; }
        public string Category{ get; set; }
        public string Distributor { get; set; }
        public string manufacture { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public Product(string name, string category, string distributor, string manufacture, int buyPrice, int sellPrice)
        {
            this.Name = name;
            this.Category = category;
            this.Distributor = distributor;
            this.manufacture = manufacture;
            this.BuyPrice = buyPrice;
            this.SellPrice = sellPrice;

        }
    }

    public class ProductDB : IDisposable
    {
        MySqlConnection conn;
        public ProductDB()
        {
            string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new MySqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public DataTable GetProductData(string category)
        {
            DataTable dt = new DataTable();
            //string sql = @"select product_no, product_name, manufacture, category, purchase_price, selling_price, distributor 
            //               from product";
            string sql = @"select product_no, product_name, manufacture, category, purchase_price, selling_price, distributor 
                           from product
                           where category = @category;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            if (category.Equals("0"))
                CommonUtil.AddParameter(da.SelectCommand, "@category", category, MySqlDbType.Int32);
            else
                CommonUtil.AddParameter(da.SelectCommand, "@category", category, MySqlDbType.VarChar);
            da.Fill(dt);
            return dt;
        }

        public DataTable GetAllProductData()
        {
            DataTable dt = new DataTable();
            string sql = @"select product_no, product_name, manufacture, category, purchase_price, selling_price, distributor 
                           from product;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
           
            da.Fill(dt);
            return dt;
        }


        public bool Insert(Product prod)
        {
            string sql = @"insert into product (product_name, manufacture, category, purchase_price, selling_price, distributor, amount)
                                        values (@product_name, @manufacture, @category, @purchase_price, @selling_price, @distributor, 0);";
            MySqlCommand cmd = new MySqlCommand(sql,conn);
            CommonUtil.AddParameter(cmd, "@product_name", prod.Name);
            CommonUtil.AddParameter(cmd, "@manufacture", prod.manufacture);
            CommonUtil.AddParameter(cmd, "@category", prod.Category);
            CommonUtil.AddParameter(cmd, "@purchase_price", prod.BuyPrice, MySqlDbType.Int32);
            CommonUtil.AddParameter(cmd, "@selling_price", prod.SellPrice, MySqlDbType.Int32);
            CommonUtil.AddParameter(cmd, "@distributor", prod.Distributor);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
                return false;
            else
                return true;
        }

        public bool Update(int pID, Product prod)
        {
            string sql = @"update product set product_name = @product_name,
                           				     manufacture = @manufacture,
                                             category = @category,
                                             purchase_price = @purchase_price,
                                             selling_price = @selling_price,
                                             distributor = distributor
                           where product_no = @pID;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            CommonUtil.AddParameter(cmd, "@product_name", prod.Name);
            CommonUtil.AddParameter(cmd, "@manufacture", prod.manufacture);
            CommonUtil.AddParameter(cmd, "@category", prod.Category);
            CommonUtil.AddParameter(cmd, "@purchase_price", prod.BuyPrice, MySqlDbType.Int32);
            CommonUtil.AddParameter(cmd, "@selling_price", prod.SellPrice, MySqlDbType.Int32);
            CommonUtil.AddParameter(cmd, "@distributor", prod.Distributor);
            CommonUtil.AddParameter(cmd, "@pID", pID,MySqlDbType.Int32);
            int result = cmd.ExecuteNonQuery();
            if (result == 0)
                return false;
            else
                return true;
        }

        public bool Delete(int pID)
        {
            string sql = "delete from product where product_no = @pID;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            CommonUtil.AddParameter(cmd, "@pID", pID,MySqlDbType.Int32);
            if (cmd.ExecuteNonQuery() == 0)
                return false;
            else 
                return true;
        }
    }
}
