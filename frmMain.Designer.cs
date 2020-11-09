namespace 화면설계
{
    partial class frmMain
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewSales = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSales = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.ptnPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewMember = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMemberInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.매장관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.직원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManual = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnRegProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.매장관리ToolStripMenuItem,
            this.btnManual,
            this.btnLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewSales,
            this.btnSales});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem1.Text = "매출관리";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btnNewSales
            // 
            this.btnNewSales.Name = "btnNewSales";
            this.btnNewSales.Size = new System.Drawing.Size(180, 22);
            this.btnNewSales.Text = "매출 등록";
            this.btnNewSales.Click += new System.EventHandler(this.btnNewSales_Click);
            // 
            // btnSales
            // 
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(180, 22);
            this.btnSales.Text = "매출 내역";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewPurchase,
            this.ptnPurchase});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem2.Text = "매입관리";
            // 
            // btnNewPurchase
            // 
            this.btnNewPurchase.Name = "btnNewPurchase";
            this.btnNewPurchase.Size = new System.Drawing.Size(126, 22);
            this.btnNewPurchase.Text = "발주 등록";
            // 
            // ptnPurchase
            // 
            this.ptnPurchase.Name = "ptnPurchase";
            this.ptnPurchase.Size = new System.Drawing.Size(126, 22);
            this.ptnPurchase.Text = "발주 내역";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewMember,
            this.btnMemberInfo});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem3.Text = "고객관리";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // btnNewMember
            // 
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(126, 22);
            this.btnNewMember.Text = "고객 등록";
            // 
            // btnMemberInfo
            // 
            this.btnMemberInfo.Name = "btnMemberInfo";
            this.btnMemberInfo.Size = new System.Drawing.Size(126, 22);
            this.btnMemberInfo.Text = "고객 정보";
            // 
            // 매장관리ToolStripMenuItem
            // 
            this.매장관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSchedule,
            this.btnGraph,
            this.직원관리ToolStripMenuItem,
            this.btnRegProduct});
            this.매장관리ToolStripMenuItem.Name = "매장관리ToolStripMenuItem";
            this.매장관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.매장관리ToolStripMenuItem.Text = "매장관리";
            // 
            // btnSchedule
            // 
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(180, 22);
            this.btnSchedule.Text = "근무 관리";
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(180, 22);
            this.btnGraph.Text = "통계";
            // 
            // 직원관리ToolStripMenuItem
            // 
            this.직원관리ToolStripMenuItem.Name = "직원관리ToolStripMenuItem";
            this.직원관리ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.직원관리ToolStripMenuItem.Text = "직원 관리";
            this.직원관리ToolStripMenuItem.Click += new System.EventHandler(this.직원관리ToolStripMenuItem_Click);
            // 
            // btnManual
            // 
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(55, 20);
            this.btnManual.Text = "매뉴얼";
            // 
            // btnLogout
            // 
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(67, 20);
            this.btnLogout.Text = "로그아웃";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnRegProduct
            // 
            this.btnRegProduct.Name = "btnRegProduct";
            this.btnRegProduct.Size = new System.Drawing.Size(180, 22);
            this.btnRegProduct.Text = "상품/거래처 등록";
            this.btnRegProduct.Click += new System.EventHandler(this.btnRegProduct_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "최건";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 매장관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnManual;
        private System.Windows.Forms.ToolStripMenuItem btnNewSales;
        private System.Windows.Forms.ToolStripMenuItem btnSales;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private System.Windows.Forms.ToolStripMenuItem btnNewPurchase;
        private System.Windows.Forms.ToolStripMenuItem ptnPurchase;
        private System.Windows.Forms.ToolStripMenuItem btnNewMember;
        private System.Windows.Forms.ToolStripMenuItem btnMemberInfo;
        private System.Windows.Forms.ToolStripMenuItem btnSchedule;
        private System.Windows.Forms.ToolStripMenuItem btnGraph;
        private System.Windows.Forms.ToolStripMenuItem 직원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRegProduct;
    }
}

