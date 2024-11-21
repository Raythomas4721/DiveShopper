using divingWebProject.Modal;
using Microsoft.Win32;
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

namespace divingWebProject.View
{
    public partial class FrmCourseEditor : Form
    {
        private CCourse _course;
        public DialogResult isOK { get;  set; }

        public CCourse course
        {
            get
            {
                if(_course == null)
                    _course = new CCourse();
                _course.courseId=Convert.ToInt32(fbCourseId.filedValue);
                _course.courseCategoryId = Convert.ToInt32(cbbCategoryId.Text); 
                _course.levelId = Convert.ToInt32(cbbLevelId.Text);
                _course.coachId = Convert.ToInt32(cbbCoachId.Text);
                _course.coursePrice = Convert.ToDecimal(fbCoursePrice.filedValue);
                _course.createdAt = Convert.ToDateTime(fbCreatedAt.filedValue);
                _course.updatedAt = Convert.ToDateTime(fbUpdatedAt.filedValue);
                return _course;
            }
            set
            {
                _course = value;
                fbCourseId.filedValue = _course.courseId.ToString();
                cbbCategoryId.Text = _course.courseCategoryId.ToString();
                cbbLevelId.Text = _course.levelId.ToString();
                cbbCoachId.Text = _course.coachId.ToString();
                fbCoursePrice.filedValue = _course.coursePrice.ToString();            
                if (_course.photo != null)
                {
                    Stream streamImage = new MemoryStream(_course.photo);
                    pictureBox1.Image = Bitmap.FromStream(streamImage);
                }
                fbCreatedAt.filedValue = _course.createdAt.ToString();
                fbUpdatedAt.filedValue = DateTime.Now.ToString();
                _course = value;
            }
        }
        public FrmCourseEditor()
        {
            InitializeComponent();
        }

        private void FrmCourseEditor_Load(object sender, EventArgs e)
        {//後續可以嘗試用comboBox顯示資料(詳見google雲端文件)
            cbbCategoryId.Items.Add("1"); //浮潛
            cbbCategoryId.Items.Add("2"); //自由潛水
            cbbCategoryId.Items.Add("3"); //水肺潛水

            cbbLevelId.Items.Add("0"); //無分級ungraded
            cbbLevelId.Items.Add("1"); //初級beginner
            cbbLevelId.Items.Add("2"); //中級intermediate
            cbbLevelId.Items.Add("3"); //高級advanced

            cbbCoachId.Items.Add("1"); //Ray
            cbbCoachId.Items.Add("2"); //Renee
            cbbCoachId.Items.Add("3"); //Chloe
        }

        

        private void fieldBox1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string message = "";
            if (cbbCategoryId.Text == "")
                message += "課程種類不可空白";

            if (cbbLevelId.Text =="")
                message += "\r\n課程程度不可空白";

            if (cbbCoachId.Text == "")
                message += ("\r\n授課教練不可空白");
            if (string.IsNullOrEmpty(fbCoursePrice.filedValue))
                message += "\r\n課程價格不可空白";
            else
            {
                if (!isNumber(fbCoursePrice.filedValue))
                {
                    message += "\r\n課程價格必須為數字";
                }
            }
            if (pictureBox1.Image == null)
                message += ("\r\n授課圖片不可空白");

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
                return;
            }
            this.isOK = DialogResult.OK;
            Close();
        }

        private bool isNumber(string p)
        {
            try
            {
                double d = Convert.ToDouble(p);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "課程照片|*.png|課程照片|*.jpg";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);

            FileStream imgStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(imgStream);
            this.course.photo= reader.ReadBytes((int)imgStream.Length);
            reader.Close();
            imgStream.Close();
        }

        private void cbbCategoryId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
