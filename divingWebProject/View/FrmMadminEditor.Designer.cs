namespace divingWebProject.View
{
    partial class FrmMadminEditor
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
            this.FieldBox1 = new divingWebProject.View.MemberFieldBox();
            this.FieldBox2 = new divingWebProject.View.MemberFieldBox();
            this.FieldBox3 = new divingWebProject.View.MemberFieldBox();
            this.FieldBox4 = new divingWebProject.View.MemberFieldBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FieldBox1
            // 
            this.FieldBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldBox1.filedName = "帳號";
            this.FieldBox1.filedValue = "";
            this.FieldBox1.Location = new System.Drawing.Point(90, 64);
            this.FieldBox1.Margin = new System.Windows.Forms.Padding(4);
            this.FieldBox1.Name = "FieldBox1";
            this.FieldBox1.passwordMask = '\0';
            this.FieldBox1.Size = new System.Drawing.Size(281, 62);
            this.FieldBox1.TabIndex = 2;
            // 
            // FieldBox2
            // 
            this.FieldBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldBox2.filedName = "電子郵件";
            this.FieldBox2.filedValue = "";
            this.FieldBox2.Location = new System.Drawing.Point(90, 134);
            this.FieldBox2.Margin = new System.Windows.Forms.Padding(4);
            this.FieldBox2.Name = "FieldBox2";
            this.FieldBox2.passwordMask = '\0';
            this.FieldBox2.Size = new System.Drawing.Size(281, 62);
            this.FieldBox2.TabIndex = 3;
            // 
            // FieldBox3
            // 
            this.FieldBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldBox3.filedName = "密碼";
            this.FieldBox3.filedValue = "";
            this.FieldBox3.Location = new System.Drawing.Point(90, 205);
            this.FieldBox3.Margin = new System.Windows.Forms.Padding(4);
            this.FieldBox3.Name = "FieldBox3";
            this.FieldBox3.passwordMask = '\0';
            this.FieldBox3.Size = new System.Drawing.Size(281, 62);
            this.FieldBox3.TabIndex = 3;
            // 
            // FieldBox4
            // 
            this.FieldBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldBox4.filedName = "確認密碼";
            this.FieldBox4.filedValue = "";
            this.FieldBox4.Location = new System.Drawing.Point(90, 275);
            this.FieldBox4.Margin = new System.Windows.Forms.Padding(4);
            this.FieldBox4.Name = "FieldBox4";
            this.FieldBox4.passwordMask = '\0';
            this.FieldBox4.Size = new System.Drawing.Size(281, 62);
            this.FieldBox4.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "一般",
            "文案管理員",
            "會員管理員",
            "系統管理員",
            "超級管理員"});
            this.comboBox1.Location = new System.Drawing.Point(90, 389);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 31);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(95, 353);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "管理角色";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(182, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 44);
            this.button2.TabIndex = 21;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(288, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 44);
            this.button1.TabIndex = 20;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(29, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "*  為必填欄位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(76, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(76, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(76, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(76, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "*";
            // 
            // FrmMadminEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 562);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.FieldBox4);
            this.Controls.Add(this.FieldBox3);
            this.Controls.Add(this.FieldBox2);
            this.Controls.Add(this.FieldBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMadminEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMadminEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MemberFieldBox FieldBox1;
        private MemberFieldBox FieldBox2;
        private MemberFieldBox FieldBox3;
        private MemberFieldBox FieldBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}