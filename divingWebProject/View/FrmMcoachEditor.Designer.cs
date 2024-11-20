using System;

namespace divingWebProject.View
{
    partial class FrmMcoachEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxDivingStyle = new System.Windows.Forms.ComboBox();
            this.coachFieldBox3 = new divingWebProject.View.MemberFieldBox();
            this.coachFieldBox2 = new divingWebProject.View.MemberFieldBox();
            this.coachFieldBox1 = new divingWebProject.View.MemberFieldBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(96, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(392, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "過去經驗";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox1.Location = new System.Drawing.Point(386, 253);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(282, 167);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(439, 471);
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
            this.button1.Location = new System.Drawing.Point(550, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 44);
            this.button1.TabIndex = 20;
            this.button1.Text = "送出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(392, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "潛水教學偏好";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBoxDivingStyle
            // 
            this.comboBoxDivingStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDivingStyle.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxDivingStyle.FormattingEnabled = true;
            this.comboBoxDivingStyle.Items.AddRange(new object[] {
            "浮潛",
            "水肺潛水",
            "自由潛水"});
            this.comboBoxDivingStyle.Location = new System.Drawing.Point(386, 166);
            this.comboBoxDivingStyle.Name = "comboBoxDivingStyle";
            this.comboBoxDivingStyle.Size = new System.Drawing.Size(281, 34);
            this.comboBoxDivingStyle.TabIndex = 25;
            // 
            // coachFieldBox3
            // 
            this.coachFieldBox3.filedName = "電話";
            this.coachFieldBox3.filedValue = "";
            this.coachFieldBox3.Location = new System.Drawing.Point(386, 49);
            this.coachFieldBox3.Margin = new System.Windows.Forms.Padding(4);
            this.coachFieldBox3.Name = "coachFieldBox3";
            this.coachFieldBox3.passwordMask = '\0';
            this.coachFieldBox3.Size = new System.Drawing.Size(281, 62);
            this.coachFieldBox3.TabIndex = 24;
            // 
            // coachFieldBox2
            // 
            this.coachFieldBox2.filedName = "性別";
            this.coachFieldBox2.filedValue = "";
            this.coachFieldBox2.Location = new System.Drawing.Point(59, 358);
            this.coachFieldBox2.Margin = new System.Windows.Forms.Padding(4);
            this.coachFieldBox2.Name = "coachFieldBox2";
            this.coachFieldBox2.passwordMask = '\0';
            this.coachFieldBox2.Size = new System.Drawing.Size(281, 62);
            this.coachFieldBox2.TabIndex = 4;
            // 
            // coachFieldBox1
            // 
            this.coachFieldBox1.filedName = "姓名";
            this.coachFieldBox1.filedValue = "";
            this.coachFieldBox1.Location = new System.Drawing.Point(59, 291);
            this.coachFieldBox1.Margin = new System.Windows.Forms.Padding(4);
            this.coachFieldBox1.Name = "coachFieldBox1";
            this.coachFieldBox1.passwordMask = '\0';
            this.coachFieldBox1.Size = new System.Drawing.Size(281, 62);
            this.coachFieldBox1.TabIndex = 3;
            // 
            // FrmMcoachEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 556);
            this.Controls.Add(this.comboBoxDivingStyle);
            this.Controls.Add(this.coachFieldBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coachFieldBox2);
            this.Controls.Add(this.coachFieldBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMcoachEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMcoachEditor";
            this.Load += new System.EventHandler(this.FrmMcoachEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MemberFieldBox coachFieldBox2;
        private MemberFieldBox coachFieldBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private MemberFieldBox coachFieldBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBoxDivingStyle;
    }
}