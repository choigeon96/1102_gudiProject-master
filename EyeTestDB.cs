using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace 화면설계
{
    public class GlassesTestInfo
    {
        //side, SPH, CYL, AXIS, far_PD, g.ADD, close_PD, OH, PRISM
        public float SPH { get; set; }
        public float CYL { get; set; }
        public float AXIS { get; set; }
        public float FarPD { get; set; }
        public float ADD { get; set; }
        public float ClosePD { get; set; }
        public float OH { get; set; }
        public float PRISM { get; set; }
        public string Side { get; set; }
        public GlassesTestInfo(string SPH, string CYL, string AXIS, string farPD, string ADD, string closePD, string OH, string PRISM, string side)
        {
            this.SPH = Convert.ToSingle(SPH);
            this.CYL = Convert.ToSingle(CYL);
            this.AXIS = Convert.ToSingle(AXIS);
            this.FarPD = Convert.ToSingle(farPD);
            this.ADD = Convert.ToSingle(ADD);
            this.ClosePD = Convert.ToSingle(closePD);
            this.OH = Convert.ToSingle(OH);
            this.PRISM = Convert.ToSingle(PRISM);
            this.Side = side;
        }
    }
    public class LensTestInfo
    {
        //side, SPH, CYL, lens_eyetest.ADD, BC, DIA, KERATO
        public float SPH { get; set; }
        public float CYL { get; set; }
        public float ADD { get; set; }
        public float BC { get; set; }
        public float DIA { get; set; }
        public float KERATO { get; set; }
        public string Side { get; set; }

        public LensTestInfo(string SPH, string CYL, string ADD, string BC, string DIA, string KERATO, string side)
        {
            this.SPH = Convert.ToSingle(SPH);
            this.CYL = Convert.ToSingle(CYL);
            this.ADD = Convert.ToSingle(ADD);
            this.BC = Convert.ToSingle(BC);
            this.DIA = Convert.ToSingle(DIA);
            this.KERATO = Convert.ToSingle(KERATO);
            this.Side = side;
        }
    }
    class EyeTestDB : IDisposable
    {
        MySqlConnection conn;
        public EyeTestDB()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            conn.Open();
        }

        public DataTable GetGlassesInfo(int memberNo)
        {
            string sql = @"select side, SPH, CYL, AXIS, far_PD, g.ADD, close_PD, OH, PRISM
                           from glasses_eyetest g
                           where eyetest_no = (select max(eyetest_no) from eyetest where member_no = @memberNo)
                           order by side;";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.Add("@memberNo",MySqlDbType.Int32);
            da.SelectCommand.Parameters["@memberNo"].Value = memberNo;

            da.Fill(dt);

            return dt;

        }

        public DataTable GetLensInfo(int memberNo)
        {
            string sql = @"select eyetest_no, side, SPH, CYL, e.ADD, BC, DIA, KERATO
                            from lens_eyetest e
                            where eyetest_no = (select max(eyetest_no) from eyetest where member_no = @memberNo)";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.Add("@memberNo", MySqlDbType.Int32);
            da.SelectCommand.Parameters["@memberNo"].Value = memberNo;

            da.Fill(dt);

            return dt;

        }

        public void Dispose()
        {
            conn.Close();
        }

        public bool Insert(int memberNo, GlassesTestInfo[] glasses, LensTestInfo[] lens)
        {
            MySqlTransaction trans =  conn.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = trans;

                cmd.CommandText = $@"insert into eyetest (member_no, emp_ID, test_date, memo)
			                                     values (@member_no, @emp_ID, '{DateTime.Now.ToString("yyyy-MM-dd")}', @memo);";
                cmd.Parameters.Add("@member_no", MySqlDbType.Int32);
                cmd.Parameters["@member_no"].Value = memberNo;
                cmd.Parameters.Add("@emp_ID", MySqlDbType.VarChar);
                cmd.Parameters["@emp_ID"].Value = frmMain.EmpID;
                cmd.Parameters.Add("@memo", MySqlDbType.VarChar);
                cmd.Parameters["@memo"].Value = "";
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = @"insert into lens_eyetest (eyetest_no, side, SPH, CYL, lens_eyetest.ADD, BC, DIA, KERATO)
				                                       values((select max(eyetest_no) from eyetest), @side, @SPH, @CYL, @ADD, @BC, @DIA, @KERATO);";
                cmd.Parameters.Add("@side", MySqlDbType.VarChar);
                cmd.Parameters.Add("@SPH", MySqlDbType.Float);
                cmd.Parameters.Add("@CYL", MySqlDbType.Float);
                cmd.Parameters.Add("@ADD", MySqlDbType.Float);
                cmd.Parameters.Add("@BC", MySqlDbType.Float);
                cmd.Parameters.Add("@DIA", MySqlDbType.Float);
                cmd.Parameters.Add("@KERATO", MySqlDbType.Float);

                SetLensParameters(cmd, lens[0]);
                cmd.ExecuteNonQuery();

                SetLensParameters(cmd, lens[1]);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = @"insert into glasses_eyetest (eyetest_no, side, SPH, CYL, AXIS, far_PD, glasses_eyetest.ADD, close_PD, OH, PRISM)
                                    values((select max(eyetest_no) from eyetest), @side, @SPH, @CYL, @AXIS, @far_PD, @ADD, @close_PD, @OH, @PRISM);";
                cmd.Parameters.Add("@side", MySqlDbType.VarChar);
                cmd.Parameters.Add("@SPH", MySqlDbType.Float);
                cmd.Parameters.Add("@CYL", MySqlDbType.Float);
                cmd.Parameters.Add("@AXIS", MySqlDbType.Float);
                cmd.Parameters.Add("@far_PD", MySqlDbType.Float);
                cmd.Parameters.Add("@ADD", MySqlDbType.Float);
                cmd.Parameters.Add("@close_PD", MySqlDbType.Float);
                cmd.Parameters.Add("@OH", MySqlDbType.Float);
                cmd.Parameters.Add("@PRISM", MySqlDbType.Float);
                SetGlassesParameters(cmd, glasses[0]);
                cmd.ExecuteNonQuery();

                SetGlassesParameters(cmd, glasses[1]);
                cmd.ExecuteNonQuery();


                trans.Commit();
                return true;
            }
            catch (Exception err)
            {
                trans.Rollback();
                throw err;
            }
        }

        private static void SetGlassesParameters(MySqlCommand cmd, GlassesTestInfo glasses)
        {
            cmd.Parameters["@side"].Value = glasses.Side;
            cmd.Parameters["@SPH"].Value = glasses.SPH;
            cmd.Parameters["@CYL"].Value = glasses.CYL;
            cmd.Parameters["@AXIS"].Value = glasses.AXIS;
            cmd.Parameters["@far_PD"].Value = glasses.FarPD;
            cmd.Parameters["@ADD"].Value = glasses.ADD;
            cmd.Parameters["@close_PD"].Value = glasses.ClosePD;
            cmd.Parameters["@OH"].Value = glasses.OH;
            cmd.Parameters["@PRISM"].Value = glasses.PRISM;
        }

        private static void SetLensParameters(MySqlCommand cmd,LensTestInfo lens)
        {
            cmd.Parameters["@side"].Value = lens.Side;
            cmd.Parameters["@SPH"].Value = lens.SPH;
            cmd.Parameters["@CYL"].Value = lens.CYL;
            cmd.Parameters["@ADD"].Value = lens.ADD;
            cmd.Parameters["@BC"].Value = lens.BC;
            cmd.Parameters["@DIA"].Value = lens.DIA;
            cmd.Parameters["@KERATO"].Value = lens.KERATO;
        }
    }
}
