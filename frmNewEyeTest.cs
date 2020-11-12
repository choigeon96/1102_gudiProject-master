using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 화면설계
{
    public partial class frmNewEyeTest : Form
    {
        private int memberNo;
        public frmNewEyeTest(int memberNo)
        {
            InitializeComponent();
            this.memberNo = memberNo;
        }

        private void frmNewEyeTest_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EyeTestDB db = new EyeTestDB();

            LensTestInfo[] lens = new LensTestInfo[2];
            lens[0] = new LensTestInfo(txtODSPH_L.Text, txtODCYL_L.Text, txtODADD_L.Text, txtODBC.Text, txtODDIA.Text, txtODKERATO.Text, "R");
            lens[1] = new LensTestInfo(txtOSSPH_L.Text, txtOSCYL_L.Text, txtOSADD_L.Text, txtOSBC.Text, txtOSDIA.Text, txtOSKERATO.Text, "L");

            GlassesTestInfo[] glasses = new GlassesTestInfo[2];
            glasses[0] = new GlassesTestInfo(txtODSPH.Text, txtODCYL.Text, txtODAXIS.Text, txtODFarPD.Text, txtODADD.Text, txtODClosePD.Text, txtODOH.Text, txtODPRISM.Text, "R");
            glasses[1] = new GlassesTestInfo(txtOSSPH.Text, txtOSCYL.Text, txtOSAXIS.Text, txtOSFarPD.Text, txtOSADD.Text, txtOSClosePD.Text, txtOSOH.Text, txtOSPRISM.Text, "L");
            try
            {
                bool result = db.Insert(memberNo, glasses, lens);
                if (result)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("등록 성공");
                    this.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            db.Dispose();
        }

            
    }
}
