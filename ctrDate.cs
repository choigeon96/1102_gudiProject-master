using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace 화면설계
{
    public partial class ctrDate : UserControl
    {
        public Panel BackPanel { get { return this.panDate; } }
        DateTime date;
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public ctrDate(Point point)
        {
            InitializeComponent();
            this.Location = point;
        }
        public void ChangeLabelText()
        {
            lblDate.Text = $"{date.Day}";
        }

        
    }
}
