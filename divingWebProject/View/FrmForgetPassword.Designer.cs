namespace divingWebProject.View
{
    partial class FrmForgetPassword
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.FieldBox2 = new divingWebProject.View.MemberFieldBox();
            this.FieldBox1 = new divingWebProject.View.MemberFieldBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FieldBox2
            // 
            this.FieldBox2.filedName = "電子郵件";
            this.FieldBox2.filedValue = "";
            this.FieldBox2.Location = new System.Drawing.Point(140, 242);
            this.FieldBox2.Name = "FieldBox2";
            this.FieldBox2.passwordMask = '\0';
            this.FieldBox2.Size = new System.Drawing.Size(281, 62);
            this.FieldBox2.TabIndex = 3;
            this.FieldBox2.Load += new System.EventHandler(this.FieldBox2_Load);
            // 
            // FieldBox1
            // 
            this.FieldBox1.filedName = "帳號";
            this.FieldBox1.filedValue = "";
            this.FieldBox1.Location = new System.Drawing.Point(140, 173);
            this.FieldBox1.Name = "FieldBox1";
            this.FieldBox1.passwordMask = '\0';
            this.FieldBox1.Size = new System.Drawing.Size(281, 62);
            this.FieldBox1.TabIndex = 2;
            this.FieldBox1.Load += new System.EventHandler(this.FieldBox1_Load);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(226, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 44);
            this.button2.TabIndex = 21;
            this.button2.Text = "送出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 148);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label1.Location = new System.Drawing.Point(195, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(133, 37);
            label1.TabIndex = 0;
            label1.Text = "忘記密碼";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label2.Location = new System.Drawing.Point(138, 102);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(285, 26);
            label2.TabIndex = 1;
            label2.Text = "我們驗證後會給您臨時通行碼";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FieldBox2);
            this.Controls.Add(this.FieldBox1);
            this.Name = "FrmForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmForgetPassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MemberFieldBox FieldBox2;
        private MemberFieldBox FieldBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}