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
    public partial class frmRegSales : Form
    {
        bool bFlag;
        DataTable dt;
        DataView dv;
        public frmRegSales()
        {
            InitializeComponent();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchAddr_Click(object sender, EventArgs e)
        {
            AddrSerachPopup popup = new AddrSerachPopup();
            if (popup.ShowDialog() == DialogResult.OK)
            {
                txtZipCode.Text = popup.ZipCode;
                txtAddr.Text = popup.Addr;
            }
        }

        private void frmRegSales_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvProduct);
            CommonUtil.AddGridTextColumn(dgvProduct, "no", "product_no", 30, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvProduct, "분류", "product_name", 80, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvProduct, "제조사", "category", 80);
            CommonUtil.AddGridTextColumn(dgvProduct, "상품명", "manufacture", 250);
            CommonUtil.AddGridTextColumn(dgvProduct, "판매가", "selling_price", 80);

            CommonUtil.SetInitGridView(dgvCart);
            //CommonUtil.AddGridTextColumn(dgvProduct, "no", "product_no", 30, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvCart, "분류", "category", 80);
            CommonUtil.AddGridTextColumn(dgvCart, "제조사", "manufacture", 80);
            CommonUtil.AddGridTextColumn(dgvCart, "상품명", "product_name", 250, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvCart, "판매가", "selling_price", 80);
            CommonUtil.AddGridTextColumn(dgvCart, "수량", "amount", 80);
            GetCategory();

            ProductDB db = new ProductDB();
            dt = db.GetAllProductData();
            dv = dt.DefaultView;
            dgvProduct.DataSource = dt;
            bFlag = true;
        }

        private bool GetCategory()
        {
            CodeDB db = new CodeDB();
            try
            {
                string[] codes = { "상품분류" };
                DataSet ds = db.GetCommonCode(codes);
                CommonUtil.BindingComboBox(cboCategory, ds.Tables["상품분류"], "code", "name");
                db.Dispose();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                db.Dispose();
                return false;
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bFlag)
            {
                dv.RowFilter = $"category = {cboCategory.SelectedItem.ToString()}";
            }
        }
    }
}
