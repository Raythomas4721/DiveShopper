using divingWebProject.Modal;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace divingWebProject.View
{
    public partial class FrmCourse : Form
    {
        SqlDataAdapter _da; //水龍頭，接收_builder產生的指給CRUD不同功能用
        SqlCommandBuilder _builder; //Sql指令的建立器、產生器(給水龍頭)

        int _position = -1;
        public FrmCourse()
        {
            InitializeComponent();
        }

        private void FrmCourseList_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True";
            con.Open();
            _da = new SqlDataAdapter("SELECT * FROM tCcourses", con);
            _builder = new SqlCommandBuilder();
            _builder.DataAdapter = _da; //產生sql指令在水龍頭_da上

            DataSet ds = new DataSet();
            _da.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0]; //把水桶的資料Table加到dataGridView上



        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmCourseEditor f = new FrmCourseEditor();
            f.ShowDialog();
            if (f.isOK == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;  // 物件轉型用as (把object轉回DataTable)
                DataRow row = dt.NewRow();
                row["courseCategoryId"] = f.course.courseCategoryId;
                row["levelId"] = f.course.levelId;
                row["coachId"] = f.course.coachId;
                row["coursePrice"] = f.course.coursePrice;
                if (f.course.photo == null)
                    return;
                row["photo"] = f.course.photo;
                row["createdAt"] = DateTime.Now;
                dt.Rows.Add(row);
            }


        }

        private void FrmCourse_FormClosed(object sender, FormClosedEventArgs e)
        { // 表單生命週期 -> FormClosed表示視窗關閉之後
            _da.Update(dataGridView1.DataSource as DataTable);


        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            //if (_ds == null)
            //    return;
            //if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            //    return;
            //_ds.WriteXml(saveFileDialog1.FileName);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {  // DataGridView裡面的一個事件，e.RowIndex點到的那一筆
            _position = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;
            DataTable dt = dataGridView1.DataSource as DataTable; //物件轉型用as
            DataRow row = dt.Rows[_position];
            row.Delete();
            _da.Update(dataGridView1.DataSource as DataTable); //連續刪，不加這句則一次只能刪一筆
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow row = dt.Rows[_position];
            CCourse x = new CCourse();
            if (row["courseId"] != DBNull.Value)
                x.courseId = Convert.ToInt32(row["courseId"]);
            x.courseCategoryId = Convert.ToInt32(row["courseCategoryId"]);
            x.levelId = Convert.ToInt32(row["levelId"]);
            x.coachId = Convert.ToInt32(row["coachId"]);
            x.coursePrice = Convert.ToDecimal(row["coursePrice"]);
            if (row["photo"] != DBNull.Value)
                x.photo = (byte[])row["photo"];
            x.createdAt = Convert.ToDateTime(row["createdAt"]);
            x.updatedAt = DateTime.Now;
            FrmCourseEditor f = new FrmCourseEditor();
            f.course = x;
            f.ShowDialog();
            if (f.isOK == DialogResult.OK)
            {
                row["courseCategoryId"] = f.course.courseCategoryId;
                row["levelId"] = f.course.levelId;
                row["coachId"] = f.course.coachId;
                row["coursePrice"] = f.course.coursePrice;
                row["photo"] = f.course.photo;
                row["createdAt"] = f.course.createdAt;
                row["updatedAt"] = f.course.updatedAt;
            }

        }

        //private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        //{  // DataGridView裡面的一個事件，e.RowIndex點到的那一筆
        //    _position = e.RowIndex;
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (_position < 0)
        //        return;
        //    DataTable dt = dataGridView1.DataSource as DataTable; //物件轉型用as
        //    DataRow row = dt.Rows[_position];
        //    row.Delete();
        //    _da.Update(dataGridView1.DataSource as DataTable); //連續刪，不加這句則一次只能刪一筆
        //}

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    if (_position < 0)
        //        return;
        //    DataTable dt = dataGridView1.DataSource as DataTable;
        //    DataRow row = dt.Rows[_position];
        //    CCourse x = new CCourse();
        //    if (row["courseId"] != DBNull.Value)
        //        x.courseId = Convert.ToInt32(row["courseId"]);
        //    x.courseCategoryId = Convert.ToInt32(row["courseCategoryId"]);
        //    x.levelId = Convert.ToInt32(row["levelId"]);
        //    x.coachId = Convert.ToInt32(row["coachId"]);
        //    x.coursePrice = Convert.ToDecimal(row["coursePrice"]);
        //    if (row["photo"] != DBNull.Value)
        //        x.photo = (byte[])row["photo"];
        //    x.createdAt = Convert.ToDateTime(row["createdAt"]);
        //    x.updatedAt = DateTime.Now;
        //    FrmCourseEditor f = new FrmCourseEditor();
        //    f.course = x;
        //    f.ShowDialog();
        //    if (f.isOK == DialogResult.OK)
        //    {
        //        row["courseCategoryId"] = f.course.courseCategoryId;
        //        row["levelId"] = f.course.levelId;
        //        row["coachId"] = f.course.coachId;
        //        row["coursePrice"] = f.course.coursePrice;
        //        row["photo"] = f.course.photo;
        //        row["createdAt"] = f.course.createdAt;
        //        row["updatedAt"] = f.course.updatedAt;
        //    }

        
    }
}
