namespace 화면설계
{
    partial class ctrDate
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
            this.panDate = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.panDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDate
            // 
            this.panDate.Controls.Add(this.lblDate);
            this.panDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDate.Location = new System.Drawing.Point(0, 0);
            this.panDate.Name = "panDate";
            this.panDate.Size = new System.Drawing.Size(70, 70);
            this.panDate.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(4, 4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(11, 12);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "1";
            // 
            // ctrDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panDate);
            this.Name = "ctrDate";
            this.Size = new System.Drawing.Size(70, 70);
            this.panDate.ResumeLayout(false);
            this.panDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panDate;
        private System.Windows.Forms.Label lblDate;
    }
}
