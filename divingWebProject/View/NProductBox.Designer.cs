namespace divingWebProject.Modal
{
    partial class NProductBox
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1NAME = new System.Windows.Forms.Label();
            this.label3PRICE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 94);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1NAME
            // 
            this.label1NAME.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1NAME.AutoSize = true;
            this.label1NAME.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1NAME.Location = new System.Drawing.Point(3, 97);
            this.label1NAME.Name = "label1NAME";
            this.label1NAME.Size = new System.Drawing.Size(53, 21);
            this.label1NAME.TabIndex = 1;
            this.label1NAME.Text = "name";
            // 
            // label3PRICE
            // 
            this.label3PRICE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3PRICE.AutoSize = true;
            this.label3PRICE.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3PRICE.Location = new System.Drawing.Point(84, 141);
            this.label3PRICE.Name = "label3PRICE";
            this.label3PRICE.Size = new System.Drawing.Size(42, 21);
            this.label3PRICE.TabIndex = 1;
            this.label3PRICE.Text = "單價";
            // 
            // NProductBox
            // 
            this.Controls.Add(this.label3PRICE);
            this.Controls.Add(this.label1NAME);
            this.Controls.Add(this.pictureBox2);
            this.Name = "NProductBox";
            this.Size = new System.Drawing.Size(129, 162);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1NAME;
        private System.Windows.Forms.Label label3PRICE;
    }
}
