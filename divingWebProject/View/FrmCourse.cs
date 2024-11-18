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

        private void toolStripButton2_Click(object sender, EventArgs e)
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
                row["createdAt"] = DateTime.Now;
                dt.Rows.Add(row);
            }
            
            
        }
    }
}
