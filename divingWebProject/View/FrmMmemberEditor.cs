using divingWebProject.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace divingWebProject.View
{
    public partial class FrmMmemberEditor : Form
    {
        public DialogResult isOK { get; set; }
        private CMmember _member;
        public CMmember member
        {
            get
            {
                if (_member == null)
                {
                    _member = new CMmember();
                }

                _member.memberName = memberFieldBox1.filedValue;
                _member.memberGender = memberFieldBox2.filedValue;
                _member.memberEmail = memberFieldBox3.filedValue;
                _member.memberPhone = memberFieldBox4.filedValue;
                _member.memberAddress = memberFieldBox5.filedValue;
                _member.memberPassword = memberFieldBox6.filedValue;
                _member.urgentContact = memberFieldBox8.filedValue;
                _member.urgentPhone = memberFieldBox9.filedValue;
                _member.recentLogin = DateTime.Today;
                return _member;
            }
            set
            {
                _member = value;
                string memberId = _member.memberId.ToString();
                memberFieldBox1.filedValue = _member.memberName;
                memberFieldBox2.filedValue = _member.memberGender;
                memberFieldBox3.filedValue = _member.memberEmail;
                memberFieldBox4.filedValue = _member.memberPhone;
                memberFieldBox5.filedValue = _member.memberAddress;
                memberFieldBox6.filedValue = _member.memberPassword;
                memberFieldBox8.filedValue = _member.urgentContact;
                memberFieldBox9.filedValue = _member.urgentPhone;

                if (_member.memberPhoto != null)
                {
                    Stream streamImage = new MemoryStream(_member.memberPhoto);
                    pictureBox1.Image = Bitmap.FromStream(streamImage);
                }

            }
        }

        public FrmMmemberEditor()
        {
            InitializeComponent();
        }

        private void memberFieldBox1_Load(object sender, EventArgs e)
        {

        }

        private void memberFieldBox2_Load(object sender, EventArgs e)
        {

        }

        private void memberFieldBox3_Load(object sender, EventArgs e)
        {

        }

        private void memberFieldBox4_Load(object sender, EventArgs e)
        {

        }

        private void memberFieldBox5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMmemberEditor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(memberFieldBox1.filedValue))
            {
                MessageBox.Show("姓名不可為空");
                return;
            }
            if (string.IsNullOrWhiteSpace(memberFieldBox2.filedValue) ||
    (memberFieldBox2.filedValue != "男" && memberFieldBox2.filedValue != "女"))
            {
                MessageBox.Show("性別請輸入男或女");
                return;
            }
            if (string.IsNullOrEmpty(memberFieldBox3.filedValue))
            {
                MessageBox.Show("電子郵件不可為空");
                return;
            }
            if (string.IsNullOrWhiteSpace(memberFieldBox6.filedValue))
            {
                MessageBox.Show("密碼欄位不可為空");
                return;
            }
            this.isOK = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void memberFieldBox6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "房間照片.JPG|*.jpg|房間照片.PNG|*.png";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);

            FileStream imgStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(imgStream);
            this.member.memberPhoto = reader.ReadBytes((int)imgStream.Length);
            reader.Close();
            imgStream.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}