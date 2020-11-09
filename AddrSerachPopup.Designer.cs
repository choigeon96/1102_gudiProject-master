namespace 화면설계
{
    partial class AddrSerachPopup
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAddrSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRoadAddr = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.btnSelectJibun = new System.Windows.Forms.Button();
            this.txtZibunAddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectRoad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "도로명(지번) 주소 검색";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(565, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAddrSearch
            // 
            this.txtAddrSearch.Location = new System.Drawing.Point(147, 12);
            this.txtAddrSearch.Name = "txtAddrSearch";
            this.txtAddrSearch.Size = new System.Drawing.Size(412, 21);
            this.txtAddrSearch.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 325);
            this.panel1.TabIndex = 5;
            // 
            // txtRoadAddr
            // 
            this.txtRoadAddr.Location = new System.Drawing.Point(110, 382);
            this.txtRoadAddr.Name = "txtRoadAddr";
            this.txtRoadAddr.ReadOnly = true;
            this.txtRoadAddr.Size = new System.Drawing.Size(449, 21);
            this.txtRoadAddr.TabIndex = 6;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(14, 382);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.ReadOnly = true;
            this.txtZipCode.Size = new System.Drawing.Size(91, 21);
            this.txtZipCode.TabIndex = 7;
            // 
            // btnSelectJibun
            // 
            this.btnSelectJibun.Location = new System.Drawing.Point(567, 421);
            this.btnSelectJibun.Name = "btnSelectJibun";
            this.btnSelectJibun.Size = new System.Drawing.Size(75, 23);
            this.btnSelectJibun.TabIndex = 3;
            this.btnSelectJibun.Text = "선택";
            this.btnSelectJibun.UseVisualStyleBackColor = true;
            this.btnSelectJibun.Click += new System.EventHandler(this.btnSelectJibun_Click);
            // 
            // txtZibunAddr
            // 
            this.txtZibunAddr.Location = new System.Drawing.Point(110, 421);
            this.txtZibunAddr.Name = "txtZibunAddr";
            this.txtZibunAddr.ReadOnly = true;
            this.txtZibunAddr.Size = new System.Drawing.Size(449, 21);
            this.txtZibunAddr.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "우편번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "지번";
            // 
            // btnSelectRoad
            // 
            this.btnSelectRoad.Location = new System.Drawing.Point(567, 382);
            this.btnSelectRoad.Name = "btnSelectRoad";
            this.btnSelectRoad.Size = new System.Drawing.Size(75, 23);
            this.btnSelectRoad.TabIndex = 3;
            this.btnSelectRoad.Text = "선택";
            this.btnSelectRoad.UseVisualStyleBackColor = true;
            this.btnSelectRoad.Click += new System.EventHandler(this.btnSelectRoad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "도로명";
            // 
            // AddrSerachPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 459);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtZibunAddr);
            this.Controls.Add(this.txtRoadAddr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelectRoad);
            this.Controls.Add(this.btnSelectJibun);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAddrSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddrSerachPopup";
            this.Text = "AddrSerachPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAddrSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRoadAddr;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Button btnSelectJibun;
        private System.Windows.Forms.TextBox txtZibunAddr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectRoad;
        private System.Windows.Forms.Label label4;
    }
}