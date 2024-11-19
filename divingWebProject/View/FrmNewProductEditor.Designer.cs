namespace divingWebProject.View
{
    partial class FrmNewProductEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewProductEditor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.fbMemo = new divingWebProject.Modal.NFieldBox();
            this.fbPrice = new divingWebProject.Modal.NFieldBox();
            this.fbCost = new divingWebProject.Modal.NFieldBox();
            this.fbName = new divingWebProject.Modal.NFieldBox();
            this.fbId = new divingWebProject.Modal.NFieldBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(316, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(291, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(430, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(10, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 2);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(335, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "<點2下新增照片>";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(302, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(254, 74);
            this.button3.TabIndex = 11;
            this.button3.Text = "庫存系統";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fbMemo
            // 
            this.fbMemo.filedName = "說明";
            this.fbMemo.filedValue = "";
            this.fbMemo.Location = new System.Drawing.Point(32, 280);
            this.fbMemo.Name = "fbMemo";
            this.fbMemo.Size = new System.Drawing.Size(231, 54);
            this.fbMemo.TabIndex = 8;
            // 
            // fbPrice
            // 
            this.fbPrice.filedName = "產品價格";
            this.fbPrice.filedValue = "";
            this.fbPrice.Location = new System.Drawing.Point(32, 194);
            this.fbPrice.Name = "fbPrice";
            this.fbPrice.Size = new System.Drawing.Size(99, 54);
            this.fbPrice.TabIndex = 7;
            // 
            // fbCost
            // 
            this.fbCost.filedName = "產品成本";
            this.fbCost.filedValue = "";
            this.fbCost.Location = new System.Drawing.Point(153, 194);
            this.fbCost.Name = "fbCost";
            this.fbCost.Size = new System.Drawing.Size(99, 54);
            this.fbCost.TabIndex = 7;
            this.fbCost.Load += new System.EventHandler(this.fbCost_Load);
            // 
            // fbName
            // 
            this.fbName.filedName = "產品名稱";
            this.fbName.filedValue = "";
            this.fbName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbName.Location = new System.Drawing.Point(32, 105);
            this.fbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbName.Name = "fbName";
            this.fbName.Size = new System.Drawing.Size(191, 69);
            this.fbName.TabIndex = 0;
            this.fbName.Load += new System.EventHandler(this.nFieldBox2_Load);
            // 
            // fbId
            // 
            this.fbId.filedName = "產品編號";
            this.fbId.filedValue = "";
            this.fbId.Location = new System.Drawing.Point(32, 28);
            this.fbId.Name = "fbId";
            this.fbId.Size = new System.Drawing.Size(134, 44);
            this.fbId.TabIndex = 0;
            this.fbId.Visible = false;
            // 
            // FrmNewProductEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(566, 479);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fbMemo);
            this.Controls.Add(this.fbPrice);
            this.Controls.Add(this.fbCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fbName);
            this.Controls.Add(this.fbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmNewProductEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewProductEditor";
            this.Load += new System.EventHandler(this.FrmNewProductEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Modal.NFieldBox fbId;
        private Modal.NFieldBox fbName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private Modal.NFieldBox fbCost;
        private Modal.NFieldBox fbPrice;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Modal.NFieldBox fbMemo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}