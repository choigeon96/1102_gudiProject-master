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
    public partial class frmRegProduct : Form
    {
        DataTable dt;
        bool tabChanged = false;
        public frmRegProduct()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmRegProduct_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvProduct);
            CommonUtil.AddGridTextColumn(dgvProduct, "no", "product_no", 30, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvProduct, "상품명", "product_name", 250, true, DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvProduct, "분류", "category", 80);
            CommonUtil.AddGridTextColumn(dgvProduct, "제조사", "manufacture", 80);
            CommonUtil.AddGridTextColumn(dgvProduct, "매입가", "purchase_price", 80, true, DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgvProduct, "판매가", "selling_price", 80, true, DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgvProduct, "거래처", "distributor", 80);
            LoadProductData();
            CodeDB code = new CodeDB();
            Dictionary<string, string> categoryList = code.GetCategory();
            code.Dispose();
            code = new CodeDB();
            List<string> manufacturerList = code.GetManufacturer();
            code.Dispose();
            code = new CodeDB();
            List<string> distributorList = code.GetDistributor();
            code.Dispose();
            foreach (string item in manufacturerList)
            {
                cmbManufacturer.Items.Add(item);
            }
            foreach (string item in distributorList)
            {
                cmbDistributor.Items.Add(item);
            }

            foreach (string item in categoryList.Keys)
            {
                cmbSearch.Items.Add(item);
                cmbCategory.Items.Add(item);
            }

        }

        private void LoadProductData()
        {
            ProductDB db = new ProductDB();
            dt = db.GetProductData("0");
            db.Dispose();
            
        }

        private void cmbCategoryS_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = $"category = '{cmbSearch.SelectedItem.ToString()}'";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Product prod = new Product(txtName.Text,
                                       cmbCategory.Text,
                                       cmbDistributor.Text,
                                       cmbManufacturer.Text,
                                       Convert.ToInt32(txtBuyPrice.Text),
                                       Convert.ToInt32(txtSellPrice.Text)
                                      );
            ProductDB db = new ProductDB();
            try
            {
                if (db.Insert(prod))
                {
                    MessageBox.Show("등록 성공");
                    LoadProductData();
                    ClearText();
                }
                else
                    throw new Exception("다시 시도하여 주십시오");
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

        private void ClearText()
        {
            if (tabControl1.SelectedTab == tabProduct)
            {
                lblID.Text = "";
                txtName.Text = "";
                cmbCategory.Text = "";
                cmbDistributor.Text = "";
                cmbManufacturer.Text = "";
                txtBuyPrice.Text = "";
                txtSellPrice.Text = "";
            }
            else
            {
                lblIDD.Text = "";
                txtDistributorName.Text = "";
                txtMobile1.Text = "";
                txtMobile2.Text = "";
                txtAddr.Text = "";
                txtAddrDetail.Text = "";
                txtZipCode.Text = "";
            }
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dgvProduct[0, e.RowIndex].Value.ToString();
            txtName.Text = dgvProduct[1, e.RowIndex].Value.ToString();
            cmbManufacturer.SelectedItem = dgvProduct[2, e.RowIndex].Value.ToString();
            cmbCategory.SelectedItem = dgvProduct[3, e.RowIndex].Value.ToString();
            txtBuyPrice.Text = dgvProduct[4, e.RowIndex].Value.ToString();
            txtSellPrice.Text = dgvProduct[5, e.RowIndex].Value.ToString();
            cmbDistributor.Text = dgvProduct[6, e.RowIndex].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product prod = new Product(txtName.Text,
                                          cmbCategory.Text,
                                          cmbDistributor.Text,
                                          cmbManufacturer.Text,
                                          Convert.ToInt32(txtBuyPrice.Text),
                                          Convert.ToInt32(txtSellPrice.Text)
                                         );
            ProductDB db = new ProductDB();
            try
            {

                if (db.Update(Convert.ToInt32(lblID.Text), prod))
                {
                    MessageBox.Show("수정 성공");
                    LoadProductData();
                    ClearText();
                }
                else
                    throw new Exception("다시 시도하여 주십시오");
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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductDB db = new ProductDB();
            if (MessageBox.Show("정말 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    if (db.Delete(Convert.ToInt32(lblID.Text)))
                    {
                        LoadProductData();
                        ClearText();
                    }
                    else
                        throw new Exception("다시 시도하여 주십시오");
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
        }
        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadDistributorData()
        {
            DistributorDB db = new DistributorDB();
            try
            {
                DataTable dt = db.GetAllData();
                dgvDistribudor.DataSource = dt;
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabDistributor && tabChanged == false)
            {
                tabChanged = true;

                CommonUtil.SetInitGridView(dgvDistribudor);
                CommonUtil.AddGridTextColumn(dgvDistribudor, "no", "distributor_no", 30, true, DataGridViewContentAlignment.MiddleCenter);
                CommonUtil.AddGridTextColumn(dgvDistribudor, "거래처명", "distributor_name", 80);
                CommonUtil.AddGridTextColumn(dgvDistribudor, "mobile1", "mobile1", 0,false);
                CommonUtil.AddGridTextColumn(dgvDistribudor, "mobile2", "mobile2", 0, false);
                CommonUtil.AddGridTextColumn(dgvDistribudor, "전화번호", "mobile", 120);
                CommonUtil.AddGridTextColumn(dgvDistribudor, "우편번호", "zipcode", 80, true, DataGridViewContentAlignment.MiddleRight);
                CommonUtil.AddGridTextColumn(dgvDistribudor, "주소", "addr1", 180, true, DataGridViewContentAlignment.MiddleRight);
                CommonUtil.AddGridTextColumn(dgvDistribudor, "상세주소", "addr2", 80);
                LoadDistributorData();

            }
        }

        private void btnInsertD_Click(object sender, EventArgs e)
        {
            Distributor dist = new Distributor(txtDistributorName.Text,
                                       txtZipCode.Text,
                                       txtAddr.Text,
                                       txtAddrDetail.Text,
                                       Convert.ToInt32(txtMobile1.Text),
                                       Convert.ToInt32(txtMobile2.Text)
                                      );
            DistributorDB db = new DistributorDB();
            try
            {
                if (db.Insert(dist))
                {
                    MessageBox.Show("등록 성공");
                    LoadDistributorData();
                    ClearText();
                }
                else
                    throw new Exception("다시 시도하여 주십시오");
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

        private void btnCloseD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateD_Click(object sender, EventArgs e)
        {
            Distributor dist = new Distributor(txtDistributorName.Text,
                                       txtZipCode.Text,
                                       lbladdr.Text,
                                       txtAddrDetail.Text,
                                       Convert.ToInt32(txtMobile1.Text),
                                       Convert.ToInt32(txtMobile2.Text)
                                      );
            DistributorDB db = new DistributorDB();
            try
            {
                if (db.Upadate(Convert.ToInt32(lblIDD.Text), dist))
                {
                    MessageBox.Show("수정 성공");
                    LoadDistributorData();
                    ClearText();
                }
                else
                    throw new Exception("다시 시도하여 주십시오");
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

        private void dgvDistribudor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIDD.Text = dgvDistribudor[0, e.RowIndex].Value.ToString();
            txtDistributorName.Text = dgvDistribudor[1, e.RowIndex].Value.ToString();
            txtMobile1.Text = dgvDistribudor[2, e.RowIndex].Value.ToString();
            txtMobile2.Text = dgvDistribudor[3, e.RowIndex].Value.ToString();
            txtZipCode.Text = dgvDistribudor[5, e.RowIndex].Value.ToString();
            txtAddr.Text = dgvDistribudor[6, e.RowIndex].Value.ToString();
            txtAddrDetail.Text = dgvDistribudor[7, e.RowIndex].Value.ToString();
        }

        private void btnDeleteD_Click(object sender, EventArgs e)
        {
            DistributorDB db = new DistributorDB();
            if (MessageBox.Show("정말 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    if (db.Delete(Convert.ToInt32(lblIDD.Text)))
                    {
                        LoadDistributorData();
                        ClearText();
                    }
                    else
                        throw new Exception("다시 시도하여 주십시오");
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
        }

        private void btnSearchZip_Click(object sender, EventArgs e)
        {
            AddrSerachPopup popup = new AddrSerachPopup();
            if (popup.ShowDialog() == DialogResult.OK)
            {
                txtZipCode.Text = popup.ZipCode;
                txtAddr.Text = popup.Addr;
            }
        }
    }
}
