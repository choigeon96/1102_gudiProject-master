using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace 화면설계
{
    public partial class Schedule : Form
    {
        DateTime date;
        public Schedule()
        {
            InitializeComponent();
        }

        private void userControl1_Load(object sender, EventArgs e)
        {
        }

        private void frmWorkRecord_Load(object sender, EventArgs e)
        {
            CreateControls();
            UpdateControls();
            EmpDB db = new EmpDB();

            try
            {
                DataTable dt = db.GetEmpName();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    clbList.Items.Add(dt.Rows[i]["emp_name"].ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            db.Dispose();
        }

        private void dtpSelectMonth_ValueChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        ctrDate[] ctrArr = new ctrDate[42];
        private void CreateControls()
        {

            int x = 0, y = 0;
            Point point = new Point(x, y);
            int cnt = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {

                    ctrArr[cnt] = new ctrDate(point);
                    point.X += 76;
                    ctrArr[cnt].BackPanel.Click += CtrClick;
                    panel1.Controls.Add(ctrArr[cnt]);
                    cnt++;
                }
                point.X = 0;
                point.Y += 76;
            }
        }

        private void CtrClick(object sender, EventArgs e)
        {
            Panel ctr = (Panel)sender;
            date = ((ctrDate)ctr.Parent).Date;
            UpdateControls();
            lbxList.Items.Clear();
            ctr.BackColor = Color.FromArgb(ctr.BackColor.R - 50, ctr.BackColor.G - 50, ctr.BackColor.B);
            EmpDB db = new EmpDB();
            try
            {
                //MessageBox.Show(((ctrDate)ctr.Parent).Date.ToString());
                DataTable dt = db.GetSchedule(((ctrDate)ctr.Parent).Date);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lbxList.Items.Add(dt.Rows[i]["emp_name"].ToString());
                    clbList.SetItemChecked(clbList.Items.IndexOf(dt.Rows[i]["emp_name"].ToString()), true);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                db.Dispose();
            }
        }

        private void UpdateControls()
        {
            btnReset_Click(null, null);

            lblSelectedMonth.Text = dtpSelectMonth.Value.ToString("yyyy년 MM월");
            int firstDay = Convert.ToInt32(new DateTime(dtpSelectMonth.Value.Year, dtpSelectMonth.Value.Month, 1).DayOfWeek);
            int lastDay = DateTime.DaysInMonth(dtpSelectMonth.Value.Year, dtpSelectMonth.Value.Month); // 선택한 달 몇일까지 있는지

            for (int i = 0; i < 42; i++)
            {
                if (i >= firstDay && i < lastDay + firstDay)
                {
                    ctrArr[i].BackPanel.BackColor = Color.FromArgb(0xB2, 0xCC, 0xFF);
                    ctrArr[i].Date = new DateTime(dtpSelectMonth.Value.Year, dtpSelectMonth.Value.Month, i - firstDay + 1);
                }
                else
                {
                    ctrArr[i].BackPanel.BackColor = Color.Gray;
                    if (i < firstDay)
                        ctrArr[i].Date = new DateTime(dtpSelectMonth.Value.Year, dtpSelectMonth.Value.Month, 1).AddDays(i - firstDay);
                    else
                        ctrArr[i].Date = ctrArr[i - 1].Date.AddDays(1);
                }
                ctrArr[i].ChangeLabelText();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbList.Items.Count; i++)
            {
                clbList.SetItemChecked(i, false);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmpDB db = new EmpDB();
            try
            {
                if (db.InsertSchedule(date, clbList.CheckedItems))
                {
                    MessageBox.Show("등록되었습니다.");
                    DataTable dt = db.GetSchedule(date);
                    lbxList.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lbxList.Items.Add(dt.Rows[i]["emp_name"].ToString());
                        clbList.SetItemChecked(clbList.Items.IndexOf(dt.Rows[i]["emp_name"].ToString()), true);
                    }
                }
                else
                    MessageBox.Show("다시 시도하여 주십시오.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                db.Dispose();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
