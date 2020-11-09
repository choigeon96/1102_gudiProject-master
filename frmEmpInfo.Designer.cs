namespace 화면설계
{
    partial class frmEmpInfo
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
            this.dgvEmpInfo = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.cmbFMobile = new System.Windows.Forms.ComboBox();
            this.txtBMobile = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPostalCode = new System.Windows.Forms.Button();
            this.txtAddrDetail = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panControls = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpInfo)).BeginInit();
            this.panControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpInfo
            // 
            this.dgvEmpInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpInfo.Location = new System.Drawing.Point(12, 12);
            this.dgvEmpInfo.Name = "dgvEmpInfo";
            this.dgvEmpInfo.RowTemplate.Height = 23;
            this.dgvEmpInfo.Size = new System.Drawing.Size(380, 371);
            this.dgvEmpInfo.TabIndex = 51;
            this.dgvEmpInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrintEmpDetail);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(517, 367);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(598, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(436, 367);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 47;
            this.btnInsert.Text = "신규등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(2, 107);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(103, 21);
            this.dtpBirthDate.TabIndex = 46;
            // 
            // cmbTitle
            // 
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Location = new System.Drawing.Point(3, 201);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(99, 20);
            this.cmbTitle.TabIndex = 44;
            // 
            // cmbFMobile
            // 
            this.cmbFMobile.FormattingEnabled = true;
            this.cmbFMobile.Location = new System.Drawing.Point(3, 171);
            this.cmbFMobile.Name = "cmbFMobile";
            this.cmbFMobile.Size = new System.Drawing.Size(53, 20);
            this.cmbFMobile.TabIndex = 45;
            // 
            // txtBMobile
            // 
            this.txtBMobile.Location = new System.Drawing.Point(62, 170);
            this.txtBMobile.Name = "txtBMobile";
            this.txtBMobile.Size = new System.Drawing.Size(140, 21);
            this.txtBMobile.TabIndex = 43;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(2, 46);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 21);
            this.txtPwd.TabIndex = 41;
            this.txtPwd.UseSystemPasswordChar = true;
            this.txtPwd.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(2, 8);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(100, 21);
            this.txtEmpID.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 33;
            this.label8.Text = "주소";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "업무";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(414, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 35;
            this.label10.Text = "전화번호";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(414, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 36;
            this.label11.Text = "생년월일";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 37;
            this.label12.Text = "이름";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(414, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 38;
            this.label13.Text = "비밀번호";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(414, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 12);
            this.label14.TabIndex = 39;
            this.label14.Text = "ID";
            // 
            // btnPostalCode
            // 
            this.btnPostalCode.Location = new System.Drawing.Point(473, 237);
            this.btnPostalCode.Name = "btnPostalCode";
            this.btnPostalCode.Size = new System.Drawing.Size(103, 23);
            this.btnPostalCode.TabIndex = 55;
            this.btnPostalCode.Text = "주소찾기";
            this.btnPostalCode.UseVisualStyleBackColor = true;
            // 
            // txtAddrDetail
            // 
            this.txtAddrDetail.Location = new System.Drawing.Point(2, 289);
            this.txtAddrDetail.Name = "txtAddrDetail";
            this.txtAddrDetail.Size = new System.Drawing.Size(200, 21);
            this.txtAddrDetail.TabIndex = 53;
            this.txtAddrDetail.TextChanged += new System.EventHandler(this.txtAddrDetail_TextChanged);
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(2, 262);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(200, 21);
            this.txtAddr.TabIndex = 54;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(115, 235);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(87, 21);
            this.txtPostalCode.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "입사일";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Location = new System.Drawing.Point(2, 139);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(103, 21);
            this.dtpHireDate.TabIndex = 46;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(2, 76);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 21);
            this.txtEmpName.TabIndex = 41;
            this.txtEmpName.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(598, 395);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "종료";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(598, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 21);
            this.btnReset.TabIndex = 56;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panControls
            // 
            this.panControls.Controls.Add(this.cmbTitle);
            this.panControls.Controls.Add(this.txtEmpID);
            this.panControls.Controls.Add(this.txtPwd);
            this.panControls.Controls.Add(this.txtEmail);
            this.panControls.Controls.Add(this.txtAddrDetail);
            this.panControls.Controls.Add(this.txtEmpName);
            this.panControls.Controls.Add(this.txtAddr);
            this.panControls.Controls.Add(this.txtBMobile);
            this.panControls.Controls.Add(this.txtPostalCode);
            this.panControls.Controls.Add(this.cmbFMobile);
            this.panControls.Controls.Add(this.dtpBirthDate);
            this.panControls.Controls.Add(this.dtpHireDate);
            this.panControls.Location = new System.Drawing.Point(471, 4);
            this.panControls.Name = "panControls";
            this.panControls.Size = new System.Drawing.Size(209, 357);
            this.panControls.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 33;
            this.label2.Text = "e-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(3, 330);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 21);
            this.txtEmail.TabIndex = 53;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtAddrDetail_TextChanged);
            // 
            // frmEmpInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 430);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPostalCode);
            this.Controls.Add(this.dgvEmpInfo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panControls);
            this.Name = "frmEmpInfo";
            this.Text = "직원 정보";
            this.Load += new System.EventHandler(this.frmEmpInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpInfo)).EndInit();
            this.panControls.ResumeLayout(false);
            this.panControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpInfo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.ComboBox cmbFMobile;
        private System.Windows.Forms.TextBox txtBMobile;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPostalCode;
        private System.Windows.Forms.TextBox txtAddrDetail;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panControls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
    }
}