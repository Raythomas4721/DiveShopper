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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fbPrice = new divingWebProject.Modal.NFieldBox();
            this.fbQty = new divingWebProject.Modal.NFieldBox();
            this.fbThickness = new divingWebProject.Modal.NFieldBox();
            this.fbGender = new divingWebProject.Modal.NFieldBox();
            this.fbSize = new divingWebProject.Modal.NFieldBox();
            this.fbColor = new divingWebProject.Modal.NFieldBox();
            this.fbName = new divingWebProject.Modal.NFieldBox();
            this.fbId = new divingWebProject.Modal.NFieldBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(289, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "確認新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 449);
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
            this.label1.Location = new System.Drawing.Point(10, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 2);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fbPrice
            // 
            this.fbPrice.filedName = "price";
            this.fbPrice.filedValue = "";
            this.fbPrice.Location = new System.Drawing.Point(323, 350);
            this.fbPrice.Name = "fbPrice";
            this.fbPrice.Size = new System.Drawing.Size(89, 54);
            this.fbPrice.TabIndex = 7;
            // 
            // fbQty
            // 
            this.fbQty.filedName = "qty";
            this.fbQty.filedValue = "";
            this.fbQty.Location = new System.Drawing.Point(462, 350);
            this.fbQty.Name = "fbQty";
            this.fbQty.Size = new System.Drawing.Size(81, 54);
            this.fbQty.TabIndex = 7;
            // 
            // fbThickness
            // 
            this.fbThickness.filedName = "thicknessId";
            this.fbThickness.filedValue = "";
            this.fbThickness.Location = new System.Drawing.Point(21, 350);
            this.fbThickness.Name = "fbThickness";
            this.fbThickness.Size = new System.Drawing.Size(222, 54);
            this.fbThickness.TabIndex = 0;
            // 
            // fbGender
            // 
            this.fbGender.filedName = "gender";
            this.fbGender.filedValue = "";
            this.fbGender.Location = new System.Drawing.Point(146, 177);
            this.fbGender.Name = "fbGender";
            this.fbGender.Size = new System.Drawing.Size(97, 54);
            this.fbGender.TabIndex = 0;
            this.fbGender.Load += new System.EventHandler(this.nFieldBox5_Load);
            // 
            // fbSize
            // 
            this.fbSize.filedName = "size";
            this.fbSize.filedValue = "";
            this.fbSize.Location = new System.Drawing.Point(21, 177);
            this.fbSize.Name = "fbSize";
            this.fbSize.Size = new System.Drawing.Size(91, 54);
            this.fbSize.TabIndex = 0;
            // 
            // fbColor
            // 
            this.fbColor.filedName = "color";
            this.fbColor.filedValue = "";
            this.fbColor.Location = new System.Drawing.Point(21, 262);
            this.fbColor.Name = "fbColor";
            this.fbColor.Size = new System.Drawing.Size(222, 54);
            this.fbColor.TabIndex = 0;
            // 
            // fbName
            // 
            this.fbName.filedName = "name";
            this.fbName.filedValue = "";
            this.fbName.Location = new System.Drawing.Point(21, 102);
            this.fbName.Name = "fbName";
            this.fbName.Size = new System.Drawing.Size(222, 69);
            this.fbName.TabIndex = 0;
            this.fbName.Load += new System.EventHandler(this.nFieldBox2_Load);
            // 
            // fbId
            // 
            this.fbId.filedName = "產品編號";
            this.fbId.filedValue = "1";
            this.fbId.Location = new System.Drawing.Point(21, 12);
            this.fbId.Name = "fbId";
            this.fbId.Size = new System.Drawing.Size(134, 44);
            this.fbId.TabIndex = 0;
            // 
            // FrmNewProductEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 521);
            this.Controls.Add(this.fbPrice);
            this.Controls.Add(this.fbQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fbThickness);
            this.Controls.Add(this.fbGender);
            this.Controls.Add(this.fbSize);
            this.Controls.Add(this.fbColor);
            this.Controls.Add(this.fbName);
            this.Controls.Add(this.fbId);
            this.Name = "FrmNewProductEditor";
            this.Text = "FrmNewProductEditor";
            this.Load += new System.EventHandler(this.FrmNewProductEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Modal.NFieldBox fbId;
        private Modal.NFieldBox fbName;
        private Modal.NFieldBox fbColor;
        private Modal.NFieldBox fbSize;
        private Modal.NFieldBox fbGender;
        private Modal.NFieldBox fbThickness;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private Modal.NFieldBox fbQty;
        private Modal.NFieldBox fbPrice;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}