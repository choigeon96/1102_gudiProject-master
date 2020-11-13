using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace 화면설계

{
    public class CommonUtil
    {

        public static void BindingComboBox(ComboBox cbo, DataTable dt, string valueMember,string displayMember, bool blankItemAdd = true)
        {
            if (blankItemAdd)
            {
                DataRow dr = dt.NewRow();
                dr[valueMember] = "";
                dr[displayMember] = "선택";
                dt.Rows.InsertAt(dr, 0);
                dt.AcceptChanges();
            }
            cbo.DisplayMember = displayMember;
            cbo.ValueMember = valueMember;
            cbo.DataSource = dt;
        }
        public static void SetInitGridView(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public static void AddGridTextColumn(
                            DataGridView dgv,
                            string headerText,
                            string dataPropertyName,
                            int colWidth = 100,
                            bool visibility = true,
                            DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.DefaultCellStyle.Alignment = textAlign;
            col.Visible = visibility;
            col.ReadOnly = true;
            dgv.Columns.Add(col);
        }
        public static void AddParameter(MySqlCommand cmd, string param, object value, MySqlDbType type = MySqlDbType.VarChar) 
        {
            cmd.Parameters.Add(param, type);
            cmd.Parameters[param].Value = value;
        }
        public static void OpenCreateForm<T>() where T : Form, new()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.Activate();
                    return;
                }
            }

            T frm = new T();
            frm.Show();
        }
        public static void OpenCreateForm<T>(bool openMdi, Form mdiParent = null) where T : Form, new()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.Activate();
                    return;
                }
            }

            T frm = new T();
            frm.MdiParent = mdiParent;
            frm.Show();
        }
    }
}
