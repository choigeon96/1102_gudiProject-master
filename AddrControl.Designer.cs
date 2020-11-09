namespace 화면설계
{
    partial class AddrControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRoadAddr = new System.Windows.Forms.Label();
            this.lblJibunAddr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCtrlNo = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "도로명주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(23, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 14);
            this.label2.TabIndex = 0;
            this.label2.Tag = "112";
            this.label2.Text = "지번";
            // 
            // lblRoadAddr
            // 
            this.lblRoadAddr.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRoadAddr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRoadAddr.Location = new System.Drawing.Point(88, 8);
            this.lblRoadAddr.Name = "lblRoadAddr";
            this.lblRoadAddr.Size = new System.Drawing.Size(409, 23);
            this.lblRoadAddr.TabIndex = 0;
            this.lblRoadAddr.Text = "경기도 고양시 일산서구 현중로 33(탄현동, 탄현마을2단지아파트)";
            this.lblRoadAddr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJibunAddr
            // 
            this.lblJibunAddr.Font = new System.Drawing.Font("나눔바른고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblJibunAddr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJibunAddr.Location = new System.Drawing.Point(89, 34);
            this.lblJibunAddr.Name = "lblJibunAddr";
            this.lblJibunAddr.Size = new System.Drawing.Size(408, 17);
            this.lblJibunAddr.TabIndex = 0;
            this.lblJibunAddr.Text = "경기도 고양시 일산서구 탄현동 1487 탄현마을2단지아파트";
            this.lblJibunAddr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(506, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "우편번호";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCtrlNo
            // 
            this.lblCtrlNo.AutoSize = true;
            this.lblCtrlNo.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCtrlNo.Location = new System.Drawing.Point(3, 25);
            this.lblCtrlNo.Name = "lblCtrlNo";
            this.lblCtrlNo.Size = new System.Drawing.Size(14, 14);
            this.lblCtrlNo.TabIndex = 0;
            this.lblCtrlNo.Text = "1";
            this.lblCtrlNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblZipCode.Location = new System.Drawing.Point(499, 31);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(65, 22);
            this.lblZipCode.TabIndex = 0;
            this.lblZipCode.Text = "10243";
            this.lblZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(570, 18);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(53, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "선택";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // AddrControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblJibunAddr);
            this.Controls.Add(this.lblRoadAddr);
            this.Controls.Add(this.lblCtrlNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddrControl";
            this.Size = new System.Drawing.Size(645, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRoadAddr;
        private System.Windows.Forms.Label lblJibunAddr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCtrlNo;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Button btnSelect;
    }
}
