using AntdUI;
using divingWebProject.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace divingWebProject.View
{
    public partial class FrmSite : Form
    {
        
        public FrmSite()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            con.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = getInsertSql();
            cmd.ExecuteNonQuery();

            con.Close();
            //MessageBox.Show("新增資料成功");



        }

        private void FrmSite_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            con.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tCustomer";

            dataGridView1.ClearSelection();
            SqlDataReader reader = cmd.ExecuteReader();
            List<CSite>list = new List<CSite>();
            
            cmd.ExecuteNonQuery();

            con.Close();
            //MessageBox.Show("新增資料成功");
        }

        private string getInsertSql()
        {
            string sql = "INSERT INTO tSsiteDetail (";
      
            sql += "VenueName,";
            sql += "NumberOfPeople,";
            sql += "VenueAddress,";
            sql += "Detail,";
            sql += "State";
            sql += ")VALUES(";
            sql += "'aaa',";
            sql += "'1',";
            sql += "'Taipei',";
            sql += "'Taipei',";
            sql += "'Taipei')";
            return sql;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True;";
            con.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM tCustomer WHERE fName='Marco'";
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("刪除資料成功");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True;";
            con.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = getUpdateSql();
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("修改資料成功");
        }

        private string getUpdateSql()
        {
            string sql = "UPDATE tSsiteDetail SET ";
            sql += "VenueName='Selina',";
            sql += "NumberOfPeople='0917445663',";
            sql += "VenueAddress='selina@gmail.com',";
            sql += "Detail='TaiChung',";
            sql += "State='TaiChung'";
            sql += " WHERE fName='Marco'";
            return sql;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True;";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = getSelectSql();

            SqlDataReader reader = cmd.ExecuteReader();
            string s = "查無資料";
            if (reader.Read())
            {
                s = reader["fName"].ToString();
                s += "\r\n" + reader["fPhone"].ToString();
            }
            con.Close();
            MessageBox.Show(s);
        }

        private string getSelectSql()
        {
            string sql = "SELECT * FROM tCustomer WHERE ";
            sql += " fName LIKE '%" + toolStripTextBox1.Text.Trim() + "%'";
            return sql;
        }
    }
}
