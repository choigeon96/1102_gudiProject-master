namespace 화면설계
{
    partial class frmRegProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panProduct = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.cmbDistributor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.tabDistributor = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDistribudor = new System.Windows.Forms.DataGridView();
            this.panDistributor = new System.Windows.Forms.Panel();
            this.lblIDD = new System.Windows.Forms.Label();
            this.btnSearchZip = new System.Windows.Forms.Button();
            this.txtAddrDetail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.lbladdr = new System.Windows.Forms.Label();
            this.txtMobile1 = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtDistributorName = new System.Windows.Forms.TextBox();
            this.txtMobile2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCloseD = new System.Windows.Forms.Button();
            this.btnDeleteD = new System.Windows.Forms.Button();
            this.btnUpdateD = new System.Windows.Forms.Button();
            this.btnInsertD = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabProduct.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tabDistributor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistribudor)).BeginInit();
            this.panDistributor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabDistributor);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 593);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.panel2);
            this.tabProduct.Controls.Add(this.panProduct);
            this.tabProduct.Controls.Add(this.groupBox1);
            this.tabProduct.Location = new System.Drawing.Point(4, 22);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(772, 567);
            this.tabProduct.TabIndex = 0;
            this.tabProduct.Text = "상품";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbSearch);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 25);
            this.panel2.TabIndex = 4;
            // 
            // cmbCategoryS
            // 
            this.cmbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(644, 2);
            this.cmbSearch.Name = "cmbCategoryS";
            this.cmbSearch.Size = new System.Drawing.Size(117, 20);
            this.cmbSearch.TabIndex = 2;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryS_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(609, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "분류";
            // 
            // panProduct
            // 
            this.panProduct.Controls.Add(this.lblID);
            this.panProduct.Controls.Add(this.label8);
            this.panProduct.Controls.Add(this.txtSellPrice);
            this.panProduct.Controls.Add(this.txtName);
            this.panProduct.Controls.Add(this.txtBuyPrice);
            this.panProduct.Controls.Add(this.cmbCategory);
            this.panProduct.Controls.Add(this.cmbManufacturer);
            this.panProduct.Controls.Add(this.cmbDistributor);
            this.panProduct.Controls.Add(this.label6);
            this.panProduct.Controls.Add(this.label5);
            this.panProduct.Controls.Add(this.label4);
            this.panProduct.Controls.Add(this.label3);
            this.panProduct.Controls.Add(this.label2);
            this.panProduct.Controls.Add(this.label1);
            this.panProduct.Controls.Add(this.btnClose);
            this.panProduct.Controls.Add(this.btnDelete);
            this.panProduct.Controls.Add(this.btnUpdate);
            this.panProduct.Controls.Add(this.btnInsert);
            this.panProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panProduct.Location = new System.Drawing.Point(3, 480);
            this.panProduct.Name = "panProduct";
            this.panProduct.Size = new System.Drawing.Size(766, 84);
            this.panProduct.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(432, 65);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 12);
            this.lblID.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "상품번호 : ";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(538, 29);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(100, 21);
            this.txtSellPrice.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 21);
            this.txtName.TabIndex = 3;
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(432, 29);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(100, 21);
            this.txtBuyPrice.TabIndex = 3;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(7, 29);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(94, 20);
            this.cmbCategory.TabIndex = 2;
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(319, 29);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(107, 20);
            this.cmbManufacturer.TabIndex = 2;
            // 
            // cmbDistributor
            // 
            this.cmbDistributor.FormattingEnabled = true;
            this.cmbDistributor.Location = new System.Drawing.Point(644, 29);
            this.cmbDistributor.Name = "cmbDistributor";
            this.cmbDistributor.Size = new System.Drawing.Size(117, 20);
            this.cmbDistributor.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "거래처";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "판매가";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "매입가";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "제조사";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "상품명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "분류";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(686, 55);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "종료";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(169, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(88, 55);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(7, 55);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "새로 등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvProduct);
            this.groupBox1.Location = new System.Drawing.Point(3, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 443);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상품목록";
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(3, 17);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowTemplate.Height = 23;
            this.dgvProduct.Size = new System.Drawing.Size(763, 423);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            // 
            // tabDistributor
            // 
            this.tabDistributor.Controls.Add(this.groupBox2);
            this.tabDistributor.Controls.Add(this.panDistributor);
            this.tabDistributor.Location = new System.Drawing.Point(4, 22);
            this.tabDistributor.Name = "tabDistributor";
            this.tabDistributor.Padding = new System.Windows.Forms.Padding(3);
            this.tabDistributor.Size = new System.Drawing.Size(772, 567);
            this.tabDistributor.TabIndex = 1;
            this.tabDistributor.Text = "거래처";
            this.tabDistributor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDistribudor);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 477);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "거래처목록";
            // 
            // dgvDistribudor
            // 
            this.dgvDistribudor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistribudor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDistribudor.Location = new System.Drawing.Point(3, 17);
            this.dgvDistribudor.Name = "dgvDistribudor";
            this.dgvDistribudor.RowTemplate.Height = 23;
            this.dgvDistribudor.Size = new System.Drawing.Size(760, 457);
            this.dgvDistribudor.TabIndex = 0;
            this.dgvDistribudor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDistribudor_CellDoubleClick);
            // 
            // panDistributor
            // 
            this.panDistributor.Controls.Add(this.lblIDD);
            this.panDistributor.Controls.Add(this.btnSearchZip);
            this.panDistributor.Controls.Add(this.txtAddrDetail);
            this.panDistributor.Controls.Add(this.label16);
            this.panDistributor.Controls.Add(this.txtAddr);
            this.panDistributor.Controls.Add(this.lbladdr);
            this.panDistributor.Controls.Add(this.txtMobile1);
            this.panDistributor.Controls.Add(this.lblMobile);
            this.panDistributor.Controls.Add(this.label9);
            this.panDistributor.Controls.Add(this.label10);
            this.panDistributor.Controls.Add(this.txtZipCode);
            this.panDistributor.Controls.Add(this.txtDistributorName);
            this.panDistributor.Controls.Add(this.txtMobile2);
            this.panDistributor.Controls.Add(this.label12);
            this.panDistributor.Controls.Add(this.label15);
            this.panDistributor.Controls.Add(this.btnCloseD);
            this.panDistributor.Controls.Add(this.btnDeleteD);
            this.panDistributor.Controls.Add(this.btnUpdateD);
            this.panDistributor.Controls.Add(this.btnInsertD);
            this.panDistributor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panDistributor.Location = new System.Drawing.Point(3, 480);
            this.panDistributor.Name = "panDistributor";
            this.panDistributor.Size = new System.Drawing.Size(766, 84);
            this.panDistributor.TabIndex = 4;
            // 
            // lblIDD
            // 
            this.lblIDD.AutoSize = true;
            this.lblIDD.Location = new System.Drawing.Point(332, 60);
            this.lblIDD.Name = "lblIDD";
            this.lblIDD.Size = new System.Drawing.Size(0, 12);
            this.lblIDD.TabIndex = 12;
            // 
            // btnSearchZip
            // 
            this.btnSearchZip.Location = new System.Drawing.Point(501, 55);
            this.btnSearchZip.Name = "btnSearchZip";
            this.btnSearchZip.Size = new System.Drawing.Size(75, 23);
            this.btnSearchZip.TabIndex = 11;
            this.btnSearchZip.Text = "주소검색";
            this.btnSearchZip.UseVisualStyleBackColor = true;
            this.btnSearchZip.Click += new System.EventHandler(this.btnSearchZip_Click);
            // 
            // txtAddrDetail
            // 
            this.txtAddrDetail.Location = new System.Drawing.Point(582, 28);
            this.txtAddrDetail.Name = "txtAddrDetail";
            this.txtAddrDetail.Size = new System.Drawing.Size(179, 21);
            this.txtAddrDetail.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(582, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 9;
            this.label16.Text = "상세주소";
            // 
            // txtAddr
            // 
            this.txtAddr.Enabled = false;
            this.txtAddr.Location = new System.Drawing.Point(356, 28);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(220, 21);
            this.txtAddr.TabIndex = 8;
            // 
            // lbladdr
            // 
            this.lbladdr.AutoSize = true;
            this.lbladdr.Location = new System.Drawing.Point(356, 10);
            this.lbladdr.Name = "lbladdr";
            this.lbladdr.Size = new System.Drawing.Size(29, 12);
            this.lbladdr.TabIndex = 7;
            this.lbladdr.Text = "주소";
            // 
            // txtMobile1
            // 
            this.txtMobile1.Location = new System.Drawing.Point(122, 28);
            this.txtMobile1.Name = "txtMobile1";
            this.txtMobile1.Size = new System.Drawing.Size(41, 21);
            this.txtMobile1.TabIndex = 6;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(120, 10);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(53, 12);
            this.lblMobile.TabIndex = 5;
            this.lblMobile.Text = "전화번호";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 12);
            this.label9.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "거래처번호 : ";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Enabled = false;
            this.txtZipCode.Location = new System.Drawing.Point(275, 28);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(76, 21);
            this.txtZipCode.TabIndex = 3;
            // 
            // txtDistributorName
            // 
            this.txtDistributorName.Location = new System.Drawing.Point(7, 28);
            this.txtDistributorName.Name = "txtDistributorName";
            this.txtDistributorName.Size = new System.Drawing.Size(108, 21);
            this.txtDistributorName.TabIndex = 3;
            // 
            // txtMobile2
            // 
            this.txtMobile2.Location = new System.Drawing.Point(169, 28);
            this.txtMobile2.Name = "txtMobile2";
            this.txtMobile2.Size = new System.Drawing.Size(100, 21);
            this.txtMobile2.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "우편번호";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "거래처명";
            // 
            // btnCloseD
            // 
            this.btnCloseD.Location = new System.Drawing.Point(686, 55);
            this.btnCloseD.Name = "btnCloseD";
            this.btnCloseD.Size = new System.Drawing.Size(75, 23);
            this.btnCloseD.TabIndex = 0;
            this.btnCloseD.Text = "종료";
            this.btnCloseD.UseVisualStyleBackColor = true;
            this.btnCloseD.Click += new System.EventHandler(this.btnCloseD_Click);
            // 
            // btnDeleteD
            // 
            this.btnDeleteD.Location = new System.Drawing.Point(169, 55);
            this.btnDeleteD.Name = "btnDeleteD";
            this.btnDeleteD.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteD.TabIndex = 0;
            this.btnDeleteD.Text = "삭제";
            this.btnDeleteD.UseVisualStyleBackColor = true;
            this.btnDeleteD.Click += new System.EventHandler(this.btnDeleteD_Click);
            // 
            // btnUpdateD
            // 
            this.btnUpdateD.Location = new System.Drawing.Point(88, 55);
            this.btnUpdateD.Name = "btnUpdateD";
            this.btnUpdateD.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateD.TabIndex = 0;
            this.btnUpdateD.Text = "수정";
            this.btnUpdateD.UseVisualStyleBackColor = true;
            this.btnUpdateD.Click += new System.EventHandler(this.btnUpdateD_Click);
            // 
            // btnInsertD
            // 
            this.btnInsertD.Location = new System.Drawing.Point(7, 55);
            this.btnInsertD.Name = "btnInsertD";
            this.btnInsertD.Size = new System.Drawing.Size(75, 23);
            this.btnInsertD.TabIndex = 0;
            this.btnInsertD.Text = "새로 등록";
            this.btnInsertD.UseVisualStyleBackColor = true;
            this.btnInsertD.Click += new System.EventHandler(this.btnInsertD_Click);
            // 
            // frmRegProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 593);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmRegProduct";
            this.Text = "상품/거래처 관리";
            this.Load += new System.EventHandler(this.frmRegProduct_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panProduct.ResumeLayout(false);
            this.panProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tabDistributor.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistribudor)).EndInit();
            this.panDistributor.ResumeLayout(false);
            this.panDistributor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TabPage tabDistributor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Panel panProduct;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.ComboBox cmbDistributor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDistribudor;
        private System.Windows.Forms.Panel panDistributor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtDistributorName;
        private System.Windows.Forms.TextBox txtMobile2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCloseD;
        private System.Windows.Forms.Button btnDeleteD;
        private System.Windows.Forms.Button btnUpdateD;
        private System.Windows.Forms.Button btnInsertD;
        private System.Windows.Forms.TextBox txtAddrDetail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Label lbladdr;
        private System.Windows.Forms.TextBox txtMobile1;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Button btnSearchZip;
        private System.Windows.Forms.Label lblIDD;
    }
}