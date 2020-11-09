using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Net;
using System.Xml;
using System.Data.Common;

namespace 화면설계
{
    public partial class AddrSerachPopup : Form
    {
        public string ZipCode { get { return txtZipCode.Text; } }
        string addr;
        public string Addr { get { return addr; }}
        public AddrSerachPopup()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAddrSearch.Text.Trim()))
            {
                MessageBox.Show("검색하실 주소를 입력하세요.");
                return;
            }

            string url = "http://www.juso.go.kr/addrlink/addrLinkApi.do";
            string apiKey = ConfigurationManager.AppSettings["RoadAPIKey"].ToString();
            string apiUrl = $"{url}?confmKey={apiKey}&currentPage=1&countPerPage=1000&keyword={txtAddrSearch.Text.Trim()}";

            WebClient wc = new WebClient();
            XmlReader reader = new XmlTextReader(wc.OpenRead(apiUrl));
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            
            if (ds.Tables.Count > 1)
            {
                DataTable dt = ds.Tables[1];
                int y = 60;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    AddrControl addr = new AddrControl();
                    addr.Location = new Point(1, 1 + (i * y));
                    addr.CtrlNo = Convert.ToString(i + 1);
                    addr.ZipCode = dt.Rows[i]["zipNo"].ToString();
                    addr.JibunAddr = dt.Rows[i]["jibunAddr"].ToString();
                    addr.RoadAddr = dt.Rows[i]["roadAddrPart1"].ToString()+ dt.Rows[i]["roadAddrPart2"].ToString();
                    addr.SelectAddr += Addr_SelectAddr;
                    panel1.Controls.Add(addr);
                }
            }
            else
                MessageBox.Show(ds.Tables[0].Rows[0]["errorMessage"].ToString());

        }

        private void Addr_SelectAddr(object sender, SelectAddrEventArgs e)
        {
            txtZipCode.Text = e.ZipCode;
            txtZibunAddr.Text = e.JibunAddr;
            txtRoadAddr.Text = e.RoadAddr;
        }

        private void btnSelectRoad_Click(object sender, EventArgs e)
        {
            this.addr = txtRoadAddr.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSelectJibun_Click(object sender, EventArgs e)
        {
            this.addr = txtZibunAddr.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
