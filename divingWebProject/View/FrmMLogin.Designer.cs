namespace divingWebProject.View
{
    partial class FrmMLogin
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FieldBox2 = new divingWebProject.View.MemberFieldBox();
            this.FieldBox1 = new divingWebProject.View.MemberFieldBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(387, 355);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(533, 355);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 55);
            this.button2.TabIndex = 20;
            this.button2.Text = "登入";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FieldBox2
            // 
            this.FieldBox2.filedName = "密碼";
            this.FieldBox2.filedValue = "";
            this.FieldBox2.Location = new System.Drawing.Point(160, 191);
            this.FieldBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FieldBox2.Name = "FieldBox2";
            this.FieldBox2.passwordMask = '\0';
            this.FieldBox2.Size = new System.Drawing.Size(375, 78);
            this.FieldBox2.TabIndex = 1;
            // 
            // FieldBox1
            // 
            this.FieldBox1.filedName = "帳號";
            this.FieldBox1.filedValue = "";
            this.FieldBox1.Location = new System.Drawing.Point(160, 105);
            this.FieldBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FieldBox1.Name = "FieldBox1";
            this.FieldBox1.passwordMask = '\0';
            this.FieldBox1.Size = new System.Drawing.Size(375, 78);
            this.FieldBox1.TabIndex = 0;
            // 
            // FrmMLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FieldBox2);
            this.Controls.Add(this.FieldBox1);
            this.Name = "FrmMLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmMLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMLogin_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private MemberFieldBox FieldBox1;
        private MemberFieldBox FieldBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}