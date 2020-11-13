namespace 화면설계
{
    partial class frmRegMember
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
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbJob = new System.Windows.Forms.ComboBox();
            this.txtMobile1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMobile2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAddrDetail = new System.Windows.Forms.TextBox();
            this.btnAddrSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddr
            // 
            this.txtAddr.Enabled = false;
            this.txtAddr.Location = new System.Drawing.Point(84, 160);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(213, 21);
            this.txtAddr.TabIndex = 49;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "남",
            "여"});
            this.cmbGender.Location = new System.Drawing.Point(245, 95);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(52, 20);
            this.cmbGender.TabIndex = 50;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(83, 21);
            this.txtName.TabIndex = 1;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(84, 95);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(103, 21);
            this.dtpBirth.TabIndex = 48;
            this.dtpBirth.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbJob
            // 
            this.cmbJob.FormattingEnabled = true;
            this.cmbJob.Location = new System.Drawing.Point(219, 20);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.Size = new System.Drawing.Size(81, 20);
            this.cmbJob.TabIndex = 47;
            // 
            // txtMobile1
            // 
            this.txtMobile1.Location = new System.Drawing.Point(84, 58);
            this.txtMobile1.Name = "txtMobile1";
            this.txtMobile1.Size = new System.Drawing.Size(41, 21);
            this.txtMobile1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 45;
            this.label7.Text = "주소";
            // 
            // txtMobile2
            // 
            this.txtMobile2.Location = new System.Drawing.Point(131, 58);
            this.txtMobile2.Name = "txtMobile2";
            this.txtMobile2.Size = new System.Drawing.Size(166, 21);
            this.txtMobile2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 43;
            this.label5.Text = "생년월일";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Enabled = false;
            this.txtZipCode.Location = new System.Drawing.Point(197, 131);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(100, 21);
            this.txtZipCode.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 42;
            this.label4.Text = "전화번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 46;
            this.label2.Text = "고객명";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(86, 224);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 51;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtAddrDetail
            // 
            this.txtAddrDetail.Location = new System.Drawing.Point(84, 187);
            this.txtAddrDetail.Name = "txtAddrDetail";
            this.txtAddrDetail.Size = new System.Drawing.Size(213, 21);
            this.txtAddrDetail.TabIndex = 49;
            // 
            // btnAddrSearch
            // 
            this.btnAddrSearch.Location = new System.Drawing.Point(84, 131);
            this.btnAddrSearch.Name = "btnAddrSearch";
            this.btnAddrSearch.Size = new System.Drawing.Size(103, 23);
            this.btnAddrSearch.TabIndex = 51;
            this.btnAddrSearch.Text = "주소찾기";
            this.btnAddrSearch.UseVisualStyleBackColor = true;
            this.btnAddrSearch.Click += new System.EventHandler(this.btnAddrSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 46;
            this.label1.Text = "직업";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 46;
            this.label3.Text = "성별";
            // 
            // frmRegMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 260);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddrSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtAddrDetail);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.cmbJob);
            this.Controls.Add(this.txtMobile1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMobile2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmRegMember";
            this.Text = "고객 등록";
            this.Load += new System.EventHandler(this.frmRegMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.ComboBox cmbJob;
        private System.Windows.Forms.TextBox txtMobile1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMobile2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAddrDetail;
        private System.Windows.Forms.Button btnAddrSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}