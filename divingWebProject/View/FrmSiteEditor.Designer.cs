namespace divingWebProject.View
{
    partial class FrmSiteEditor
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
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.memberFieldBox6 = new divingWebProject.View.MemberFieldBox();
            this.memberFieldBox5 = new divingWebProject.View.MemberFieldBox();
            this.memberFieldBox4 = new divingWebProject.View.MemberFieldBox();
            this.memberFieldBox3 = new divingWebProject.View.MemberFieldBox();
            this.memberFieldBox2 = new divingWebProject.View.MemberFieldBox();
            this.memberFieldBox1 = new divingWebProject.View.MemberFieldBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(409, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(345, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(493, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "確定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(322, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(70, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "*表示必須填寫";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(413, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "*上圖點兩下可選圖片";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(35, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(601, 2);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // memberFieldBox6
            // 
            this.memberFieldBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberFieldBox6.filedName = "編號";
            this.memberFieldBox6.filedValue = "0";
            this.memberFieldBox6.Location = new System.Drawing.Point(35, 373);
            this.memberFieldBox6.Name = "memberFieldBox6";
            this.memberFieldBox6.passwordMask = '\0';
            this.memberFieldBox6.Size = new System.Drawing.Size(281, 62);
            this.memberFieldBox6.TabIndex = 3;
            this.memberFieldBox6.Visible = false;
            // 
            // memberFieldBox5
            // 
            this.memberFieldBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberFieldBox5.filedName = "狀態";
            this.memberFieldBox5.filedValue = "";
            this.memberFieldBox5.Location = new System.Drawing.Point(35, 305);
            this.memberFieldBox5.Name = "memberFieldBox5";
            this.memberFieldBox5.passwordMask = '\0';
            this.memberFieldBox5.Size = new System.Drawing.Size(281, 62);
            this.memberFieldBox5.TabIndex = 0;
            // 
            // memberFieldBox4
            // 
            this.memberFieldBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberFieldBox4.filedName = "描述";
            this.memberFieldBox4.filedValue = "";
            this.memberFieldBox4.Location = new System.Drawing.Point(35, 237);
            this.memberFieldBox4.Name = "memberFieldBox4";
            this.memberFieldBox4.passwordMask = '\0';
            this.memberFieldBox4.Size = new System.Drawing.Size(281, 62);
            this.memberFieldBox4.TabIndex = 0;
            // 
            // memberFieldBox3
            // 
            this.memberFieldBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberFieldBox3.filedName = "場地地址";
            this.memberFieldBox3.filedValue = "";
            this.memberFieldBox3.Location = new System.Drawing.Point(35, 169);
            this.memberFieldBox3.Name = "memberFieldBox3";
            this.memberFieldBox3.passwordMask = '\0';
            this.memberFieldBox3.Size = new System.Drawing.Size(281, 62);
            this.memberFieldBox3.TabIndex = 0;
            // 
            // memberFieldBox2
            // 
            this.memberFieldBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberFieldBox2.filedName = "場地人數";
            this.memberFieldBox2.filedValue = "";
            this.memberFieldBox2.Location = new System.Drawing.Point(35, 101);
            this.memberFieldBox2.Name = "memberFieldBox2";
            this.memberFieldBox2.passwordMask = '\0';
            this.memberFieldBox2.Size = new System.Drawing.Size(281, 62);
            this.memberFieldBox2.TabIndex = 0;
            this.memberFieldBox2.Load += new System.EventHandler(this.memberFieldBox2_Load);
            // 
            // memberFieldBox1
            // 
            this.memberFieldBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberFieldBox1.filedName = "場地名稱";
            this.memberFieldBox1.filedValue = "";
            this.memberFieldBox1.Location = new System.Drawing.Point(35, 33);
            this.memberFieldBox1.Name = "memberFieldBox1";
            this.memberFieldBox1.passwordMask = '\0';
            this.memberFieldBox1.Size = new System.Drawing.Size(281, 62);
            this.memberFieldBox1.TabIndex = 0;
            this.memberFieldBox1.Load += new System.EventHandler(this.memberFieldBox1_Load);
            // 
            // FrmSiteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 519);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memberFieldBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.memberFieldBox5);
            this.Controls.Add(this.memberFieldBox4);
            this.Controls.Add(this.memberFieldBox3);
            this.Controls.Add(this.memberFieldBox2);
            this.Controls.Add(this.memberFieldBox1);
            this.Name = "FrmSiteEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSiteEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MemberFieldBox memberFieldBox1;
        private MemberFieldBox memberFieldBox2;
        private MemberFieldBox memberFieldBox3;
        private MemberFieldBox memberFieldBox4;
        private MemberFieldBox memberFieldBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MemberFieldBox memberFieldBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}