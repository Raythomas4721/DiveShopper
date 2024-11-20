namespace divingWebProject.View
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FrmMember = new System.Windows.Forms.ToolStripButton();
            this.FrmNewProduct = new System.Windows.Forms.ToolStripButton();
            this.FrmUsedProduct = new System.Windows.Forms.ToolStripButton();
            this.FrmCourse = new System.Windows.Forms.ToolStripButton();
            this.FrmSite = new System.Windows.Forms.ToolStripButton();
            this.FrmOrder = new System.Windows.Forms.ToolStripButton();
            this.FrmReview = new System.Windows.Forms.ToolStripButton();
            this.FrmAdminSetting = new System.Windows.Forms.ToolStripButton();
            this.FrmCoachList = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FrmMember,
            this.FrmCoachList,
            this.FrmNewProduct,
            this.FrmUsedProduct,
            this.FrmCourse,
            this.FrmSite,
            this.FrmOrder,
            this.FrmReview,
            this.FrmAdminSetting,
            this.toolStripButton10});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.toolStrip1.Size = new System.Drawing.Size(255, 722);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FrmMember
            // 
            this.FrmMember.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmMember.Image = ((System.Drawing.Image)(resources.GetObject("FrmMember.Image")));
            this.FrmMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FrmMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FrmMember.Name = "FrmMember";
            this.FrmMember.Padding = new System.Windows.Forms.Padding(8);
            this.FrmMember.Size = new System.Drawing.Size(150, 51);
            this.FrmMember.Text = "會員管理";
            this.FrmMember.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrmNewProduct
            // 
            this.FrmNewProduct.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmNewProduct.Image = ((System.Drawing.Image)(resources.GetObject("FrmNewProduct.Image")));
            this.FrmNewProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FrmNewProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FrmNewProduct.Name = "FrmNewProduct";
            this.FrmNewProduct.Padding = new System.Windows.Forms.Padding(8);
            this.FrmNewProduct.Size = new System.Drawing.Size(174, 51);
            this.FrmNewProduct.Text = "新商品管理";
            this.FrmNewProduct.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // FrmUsedProduct
            // 
            this.FrmUsedProduct.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmUsedProduct.Image = ((System.Drawing.Image)(resources.GetObject("FrmUsedProduct.Image")));
            this.FrmUsedProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FrmUsedProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FrmUsedProduct.Name = "FrmUsedProduct";
            this.FrmUsedProduct.Padding = new System.Windows.Forms.Padding(8);
            this.FrmUsedProduct.Size = new System.Drawing.Size(198, 51);
            this.FrmUsedProduct.Text = "二手商品管理";
            this.FrmUsedProduct.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // FrmCourse
            // 
            this.FrmCourse.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmCourse.Image = ((System.Drawing.Image)(resources.GetObject("FrmCourse.Image")));
            this.FrmCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FrmCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FrmCourse.Name = "FrmCourse";
            this.FrmCourse.Padding = new System.Windows.Forms.Padding(8);
            this.FrmCourse.Size = new System.Drawing.Size(150, 51);
            this.FrmCourse.Text = "課程管理";
            this.FrmCourse.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // FrmSite
            // 
            this.FrmSite.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmSite.Image = ((System.Drawing.Image)(resources.GetObject("FrmSite.Image")));
            this.FrmSite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FrmSite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FrmSite.Name = "FrmSite";
            this.FrmSite.Padding = new System.Windows.Forms.Padding(8);
            this.FrmSite.Size = new System.Drawing.Size(150, 51);
            this.FrmSite.Text = "場地管理";
            this.FrmSite.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // FrmOrder
            // 
            this.FrmOrder.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmOrder.Image = ((System.Drawing.Image)(resources.GetObject("FrmOrder.Image")));
            this.FrmOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FrmOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FrmOrder.Name = "FrmOrder";
            this.FrmOrder.Padding = new System.Windows.Forms.Padding(8);
            this.FrmOrder.Size = new System.Drawing.Size(150, 51);
            this.FrmOrder.Text = "訂單管理";
            this.FrmOrder.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // FrmReview
            // 
            this.FrmReview.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmReview.Image = ((System.Drawing.Image)(resources.GetObject("FrmReview.Image")));
            this.FrmReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FrmReview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FrmReview.Name = "FrmReview";
            this.FrmReview.Padding = new System.Windows.Forms.Padding(8);
            this.FrmReview.Size = new System.Drawing.Size(150, 51);
            this.FrmReview.Text = "評論管理";
            this.FrmReview.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // FrmAdminSetting
            // 
            this.FrmAdminSetting.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmAdminSetting.Image = ((System.Drawing.Image)(resources.GetObject("FrmAdminSetting.Image")));
            this.FrmAdminSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FrmAdminSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FrmAdminSetting.Name = "FrmAdminSetting";
            this.FrmAdminSetting.Padding = new System.Windows.Forms.Padding(8);
            this.FrmAdminSetting.Size = new System.Drawing.Size(174, 51);
            this.FrmAdminSetting.Text = "管理者設定";
            this.FrmAdminSetting.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // FrmCoachList
            // 
            this.FrmCoachList.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FrmCoachList.Image = ((System.Drawing.Image)(resources.GetObject("FrmCoachList.Image")));
            this.FrmCoachList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FrmCoachList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FrmCoachList.Name = "FrmCoachList";
            this.FrmCoachList.Padding = new System.Windows.Forms.Padding(8);
            this.FrmCoachList.Size = new System.Drawing.Size(150, 51);
            this.FrmCoachList.Text = "教練管理";
            this.FrmCoachList.Click += new System.EventHandler(this.toolStripButton9_Click_1);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Margin = new System.Windows.Forms.Padding(0, 240, 0, 2);
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButton10.Size = new System.Drawing.Size(158, 35);
            this.toolStripButton10.Text = "使用者您好";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 722);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton FrmMember;
        private System.Windows.Forms.ToolStripButton FrmNewProduct;
        private System.Windows.Forms.ToolStripButton FrmUsedProduct;
        private System.Windows.Forms.ToolStripButton FrmCourse;
        private System.Windows.Forms.ToolStripButton FrmSite;
        private System.Windows.Forms.ToolStripButton FrmOrder;
        private System.Windows.Forms.ToolStripButton FrmCoachList;
        private System.Windows.Forms.ToolStripButton FrmReview;
        private System.Windows.Forms.ToolStripButton FrmAdminSetting;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
    }
}