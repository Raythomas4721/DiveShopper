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
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace divingWebProject.View
{
    public partial class FrmCourse : Form
    {
        SqlDataAdapter _da; //水龍頭，接收_builder產生的指給CRUD不同功能用
        SqlCommandBuilder _builder; //Sql指令的建立器、產生器(給水龍頭)
        DataSet _ds = null;
        int _position = -1;
        public FrmCourse()
        {
            InitializeComponent();
        }

        private void FrmCourseList_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            //dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
            //dataGridView1.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            //dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            displayCoursesBySql("SELECT * FROM tCcourses",false);
            dataGridView1.Columns["coursePrice"].DefaultCellStyle.Format = "0"; // 去掉小數位

            label1.BackColor = System.Drawing.Color.FromArgb(108, 122, 137 ); 
            toolStrip1.BackColor = System.Drawing.Color.FromArgb(163, 198, 196);
            dataGridView1.Columns[0].HeaderCell.Style.BackColor = SystemColors.Control; // 默認背景色
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(224, 231, 233); //偶數行
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); //奇數行
            resetGridstyle1();

        }

        private void displayCoursesBySql(string sql,bool isKeyword)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True";
            con.Open();

            _da = new SqlDataAdapter("SELECT * FROM tCcourses", con); 
            if (isKeyword)
            {
                _da.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD", (object)("%" + txtKeyword.Text + "%"))); //把keyWord型別string轉成int失敗了
                //豪華型水龍頭
            }
            _builder = new SqlCommandBuilder();
            _builder.DataAdapter = _da; //產生sql指令在水龍頭_da上

            _ds = new DataSet();
            _da.Fill(_ds);
            con.Close();
            dataGridView1.DataSource = _ds.Tables[0]; //把水桶的資料Table加到dataGridView上
            resetGridstyle1();
        }
        private void resetGridstyle1()
        {

            //dataGridView1.Columns[0].Width = 100;
            //dataGridView1.Columns[1].Width = 100;
            //dataGridView1.Columns[2].Width = 100;
            //dataGridView1.Columns[3].Width = 100;
            //dataGridView1.Columns[4].Width = 100;
            //dataGridView1.Columns[5].Width = 100;

            dataGridView1.Columns[0].HeaderText = "課程ID";
            dataGridView1.Columns[1].HeaderText = "課程種類ID";
            dataGridView1.Columns[2].HeaderText = "等級ID";
            dataGridView1.Columns[3].HeaderText = "教練ID";
            dataGridView1.Columns[4].HeaderText = "價格";
            dataGridView1.Columns[5].HeaderText = "圖片";
            dataGridView1.Columns[6].HeaderText = "建立日期";
            dataGridView1.Columns[7].HeaderText = "更新日期";
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
            _da.Update(dataGridView1.DataSource as DataTable);
            displayCoursesBySql("SELECT *　FROM tCcourse",false);
            //Close();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (_ds == null)
                return;
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            _ds.WriteXml(saveFileDialog1.FileName);
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
            if (f.isOK == DialogResult.OK) //畫面點確定按鈕
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string sql = "SELECT * FROM vw_CourseDetails WHERE ";
            //sql += "cc.categoryName LIKE @K_KEYWORD";
            //sql += " OR cl.levelName LIKE @K_KEYWORD";
            //sql += " OR co.coachName LIKE @K_KEYWORD";
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True";
            //con.Open();

            //_da = new SqlDataAdapter(sql, con);
            //if (!string.IsNullOrEmpty(txtKeyword.Text))
            //{
            //    _da.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD", (object)("%" + txtKeyword.Text + "%")));
            //}
            //_builder = new SqlCommandBuilder();
            //_builder.DataAdapter = _da; //產生sql指令在水龍頭_da上

            //DataSet ds = new DataSet();
            //_da.Fill(ds);
            //con.Close();
            //dataGridView1.DataSource = ds.Tables[0]; //把水桶的資料Table加到dataGridView上




            //string sql = "SELECT * FROM tCcourses WHERE ";
            //sql += " courseCategoryId LIKE @K_KEYWORD";
            //sql += " OR levelId LIKE @K_KEYWORD";
            //sql += " OR coachId LIKE @K_KEYWORD";
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True";
            //con.Open();

            //_da = new SqlDataAdapter("SELECT * FROM tCcourses;SELECT * FROM vw_CourseDetails", con); //_da = new SqlDataAdapter("SELECT * FROM tCcourses", con);
            //if (txtKeyword.Text != null)
            //{
            //    _da.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD", (object)("%" + txtKeyword.Text + "%"))); //把keyWord型別string轉成int失敗了
            //    //豪華型水龍頭
            //}
            //_builder = new SqlCommandBuilder();
            //_builder.DataAdapter = _da; //產生sql指令在水龍頭_da上

            //DataSet ds = new DataSet();
            //_da.Fill(ds);
            //con.Close();
            //dataGridView1.DataSource = ds.Tables[0]; //把水桶的資料Table加到dataGridView上

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemoTest;Integrated Security=True";
            //con.Open();

            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = getBySql();
            ////if (isKey)
            //    //cmd.Parameters.Add(new SqlParameter("K_QRY", (object)("%" + textBox1.Text.Trim()) + "%"));
            //SqlDataReader reader = cmd.ExecuteReader();
            //DataGridView.Items.Clear();
            //_listPK = new List<int>();
            //while (reader.Read())
            //{
            //    _listPK.Add(Convert.ToInt32(reader["fId"]));
            //    listBox1.Items.Add(reader["fName"].ToString() + "\t" + reader["fPhone"].ToString());
            //}
            //con.Close();

            // 定義 SQL 查詢
            string sql = "SELECT * FROM vw_CourseDetails WHERE ";
            sql += " [課程] LIKE @K_KEYWORD"; 
            sql += " OR [等級] LIKE @K_KEYWORD"; 
            sql += " OR [教練] LIKE @K_KEYWORD";

            //using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True"))
            //{
            //    con.Open();

            //    using (SqlCommand cmd = new SqlCommand(sql, con))
            //    {
            //        // 檢查 txtKeyword 是否為有效的字符串
            //        if (!string.IsNullOrEmpty(txtKeyword.Text))
            //        {
            //            // 使用 '%' 符號來進行模糊匹配
            //            string keyword = "%" + txtKeyword.Text + "%";
            //            cmd.Parameters.Add(new SqlParameter("@K_KEYWORD", keyword));
            //        }
            //        else
            //        {
            //            MessageBox.Show("請輸入有效的關鍵字。");
            //            return; // 退出方法
            //        }

            //        // 使用 SqlDataAdapter 來填充 DataSet
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataSet ds = new DataSet();
            //        da.Fill(ds); // 填充 DataSet

            //        // 將資料綁定到 DataGridView
            //        if (ds.Tables.Count > 0)
            //        {
            //            dataGridView1.DataSource = ds.Tables[0];
            //        }
            //    }
            //}
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            if (!string.IsNullOrEmpty(txtKeyword.Text))
            {                
                string keyword = "%" + txtKeyword.Text + "%";
                cmd.Parameters.Add(new SqlParameter("@K_KEYWORD", keyword));
            }else
            {
                MessageBox.Show("請輸入有效的關鍵字。");
                return; // 退出方法
            }
            // 使用 SqlDataAdapter 來填充 DataSet
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds); // 填充 DataSet
            // 將資料綁定到 DataGridView
            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;

        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            displayCoursesBySql("SELECT * FROM tCcourses", false);
            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
           

        }

        private void FrmCourse_Paint(object sender, PaintEventArgs e)
        {
            resetGridstyle1();
        }
    }
}
