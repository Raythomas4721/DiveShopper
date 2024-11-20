namespace divingWebProject.View
{
    partial class FrmProductvariantEditor
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fbSize = new Sunny.UI.UIComboBox();
            this.fbColor = new Sunny.UI.UIComboBox();
            this.fbGender = new Sunny.UI.UIComboBox();
            this.fbThickness = new Sunny.UI.UIComboBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.fbstock = new divingWebProject.Modal.NFieldBox();
            this.fbId = new divingWebProject.Modal.NFieldBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(28, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "性別分類";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(28, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "產品尺寸";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(28, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "產品顏色";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "防寒衣厚度";
            // 
            // fbSize
            // 
            this.fbSize.DataSource = null;
            this.fbSize.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.fbSize.FillColor = System.Drawing.Color.White;
            this.fbSize.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbSize.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.fbSize.Items.AddRange(new object[] {
            "無選擇",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.fbSize.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.fbSize.Location = new System.Drawing.Point(116, 162);
            this.fbSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fbSize.MinimumSize = new System.Drawing.Size(63, 0);
            this.fbSize.Name = "fbSize";
            this.fbSize.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.fbSize.Size = new System.Drawing.Size(150, 29);
            this.fbSize.SymbolSize = 24;
            this.fbSize.TabIndex = 9;
            this.fbSize.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbSize.Watermark = "";
            // 
            // fbColor
            // 
            this.fbColor.DataSource = null;
            this.fbColor.FillColor = System.Drawing.Color.White;
            this.fbColor.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbColor.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.fbColor.Items.AddRange(new object[] {
            "無選擇",
            "藍色",
            "黑色",
            "白色",
            "紅色"});
            this.fbColor.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.fbColor.Location = new System.Drawing.Point(116, 217);
            this.fbColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fbColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.fbColor.Name = "fbColor";
            this.fbColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.fbColor.Size = new System.Drawing.Size(150, 29);
            this.fbColor.SymbolSize = 24;
            this.fbColor.TabIndex = 10;
            this.fbColor.Text = "uiComboBox1";
            this.fbColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbColor.Watermark = "";
            this.fbColor.Validated += new System.EventHandler(this.fbColor_Validated);
            // 
            // fbGender
            // 
            this.fbGender.DataSource = null;
            this.fbGender.FillColor = System.Drawing.Color.White;
            this.fbGender.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbGender.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.fbGender.Items.AddRange(new object[] {
            "無選擇",
            "女款半身",
            "女款全身",
            "男款半身",
            "男款全身"});
            this.fbGender.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.fbGender.Location = new System.Drawing.Point(116, 271);
            this.fbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fbGender.MinimumSize = new System.Drawing.Size(63, 0);
            this.fbGender.Name = "fbGender";
            this.fbGender.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.fbGender.Size = new System.Drawing.Size(150, 29);
            this.fbGender.SymbolSize = 24;
            this.fbGender.TabIndex = 11;
            this.fbGender.Text = "uiComboBox1";
            this.fbGender.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbGender.Watermark = "";
            // 
            // fbThickness
            // 
            this.fbThickness.DataSource = null;
            this.fbThickness.FillColor = System.Drawing.Color.White;
            this.fbThickness.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbThickness.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.fbThickness.Items.AddRange(new object[] {
            "無選擇",
            "1.5mm",
            "3mm",
            "5mm",
            "7mm"});
            this.fbThickness.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.fbThickness.Location = new System.Drawing.Point(116, 327);
            this.fbThickness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fbThickness.MinimumSize = new System.Drawing.Size(63, 0);
            this.fbThickness.Name = "fbThickness";
            this.fbThickness.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.fbThickness.Size = new System.Drawing.Size(150, 29);
            this.fbThickness.SymbolSize = 24;
            this.fbThickness.TabIndex = 12;
            this.fbThickness.Text = "uiComboBox1";
            this.fbThickness.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbThickness.Watermark = "";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton1.Location = new System.Drawing.Point(52, 393);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(86, 45);
            this.uiButton1.TabIndex = 13;
            this.uiButton1.Text = "確認";
            this.uiButton1.TipsFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click_1);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton2.Location = new System.Drawing.Point(193, 393);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(86, 45);
            this.uiButton2.TabIndex = 14;
            this.uiButton2.Text = "取消";
            this.uiButton2.TipsFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click_1);
            // 
            // fbstock
            // 
            this.fbstock.filedName = "數量";
            this.fbstock.filedValue = "";
            this.fbstock.Location = new System.Drawing.Point(52, 73);
            this.fbstock.Name = "fbstock";
            this.fbstock.Size = new System.Drawing.Size(139, 55);
            this.fbstock.TabIndex = 2;
            // 
            // fbId
            // 
            this.fbId.filedName = "產品編號";
            this.fbId.filedValue = "";
            this.fbId.Location = new System.Drawing.Point(52, 12);
            this.fbId.Name = "fbId";
            this.fbId.Size = new System.Drawing.Size(139, 55);
            this.fbId.TabIndex = 1;
            // 
            // FrmProductvariantEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.fbThickness);
            this.Controls.Add(this.fbGender);
            this.Controls.Add(this.fbColor);
            this.Controls.Add(this.fbSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fbstock);
            this.Controls.Add(this.fbId);
            this.Name = "FrmProductvariantEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProductvariantEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Modal.NFieldBox fbId;
        private Modal.NFieldBox fbstock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIComboBox fbSize;
        private Sunny.UI.UIComboBox fbColor;
        private Sunny.UI.UIComboBox fbGender;
        private Sunny.UI.UIComboBox fbThickness;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
    }
}