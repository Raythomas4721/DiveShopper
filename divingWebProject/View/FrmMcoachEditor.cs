using divingWebProject.Modal;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace divingWebProject.View
{
    public partial class FrmMcoachEditor : Form
    {
        public DialogResult isOK { get; set; }
        private CMcoaches _coach;
        public FrmMcoachEditor()
        {
            InitializeComponent();
        }
        public CMcoaches coach
        {
            get
            {
                if (_coach == null)
                {
                    _coach = new CMcoaches();
                }

                _coach.coachName = coachFieldBox1.filedValue;
                _coach.gender = coachFieldBox2.filedValue;
                _coach.coachPhone = coachFieldBox3.filedValue;
                _coach.experience = richTextBox1.Text;


                return _coach;
            }
            set
            {
                _coach = value;
                coachFieldBox1.filedValue = _coach.coachName;
                coachFieldBox2.filedValue = _coach.gender;
                coachFieldBox3.filedValue = _coach.coachPhone;
                richTextBox1.Text = _coach.experience;

                if (_coach.photo != null)
                {
                    Stream streamImage = new MemoryStream(_coach.photo);
                    pictureBox1.Image = Bitmap.FromStream(streamImage);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(coachFieldBox1.filedValue))
            {
                MessageBox.Show("教練姓名不可為空");
                return;
            }
            if (string.IsNullOrWhiteSpace(coachFieldBox2.filedValue) ||
    (coachFieldBox2.filedValue != "男" && coachFieldBox2.filedValue != "女"))
            {
                MessageBox.Show("教練性別請輸入男或女");
                return;
            }
            isOK = DialogResult.OK; 
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "教練照片.JPG|*.jpg|教練照片.PNG|*.png";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);

            FileStream imgStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(imgStream);
            this.coach.photo = reader.ReadBytes((int)imgStream.Length);
            reader.Close();
            imgStream.Close();
        }
        private void FrmMcoachEditor_Load(object sender, EventArgs e)
        {
        }
    }
}
