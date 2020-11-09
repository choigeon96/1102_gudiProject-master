using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 화면설계
{
    public partial class AddrControl : UserControl
    {

        public delegate void SelectAddrEventHandler(object sender, SelectAddrEventArgs e);
        public event SelectAddrEventHandler SelectAddr;

        public string CtrlNo { get { return lblCtrlNo.Text; } set { lblCtrlNo.Text = value; } }
        public string RoadAddr { get { return lblRoadAddr.Text; } set { lblRoadAddr.Text = value; } }
        public string JibunAddr { get { return lblJibunAddr.Text; } set { lblJibunAddr.Text = value; } }
        public string ZipCode { get { return lblZipCode.Text; } set { lblZipCode.Text = value; } }
        public AddrControl()
        {
            InitializeComponent();
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (SelectAddr != null) //등록된 이벤트 핸들러가 있는지 체크
            {
                SelectAddrEventArgs args = new SelectAddrEventArgs();
                args.ZipCode = this.ZipCode;
                args.RoadAddr = this.RoadAddr;
                args.JibunAddr = this.JibunAddr;

                SelectAddr(this, args); //이벤트 발생
            }
        }
    }

    public class SelectAddrEventArgs : EventArgs
    {

        private string zipCode;
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        private string roadAddr;
        public string RoadAddr
        {
            get { return roadAddr; }
            set { roadAddr = value; }
        }

        private string jibunAddr;
        public string JibunAddr
        {
            get { return jibunAddr; }
            set { jibunAddr = value; }
        }

    }
}
