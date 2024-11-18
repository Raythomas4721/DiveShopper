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
using System.Windows.Forms;

namespace divingWebProject.View
{
    public partial class FrmNewProductvariant : Form
    {
        public FrmNewProductvariant()
        {
            InitializeComponent();
        }

        private List<int> _listPK;
        int _position = -1;
        private void displayNewProductvariantsBySql(string sql, bool isKeyword)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;

            if (isKeyword)
                cmd.Parameters.Add(new SqlParameter("K_KEYWORD", "%" + (object)txtKeyword.Text + "%"));

            DataTable dataTable = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;

            if (isKeyword)
                cmd.Parameters.Add(new SqlParameter("K_KEYWORD", "%" + (object)txtKeyword.Text + "%"));

            resetGridstyle();

        }


        private void resetGridstyle()//第二個表
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].Width = 300;
            dataGridView1.Columns[4].Width = 300;
            dataGridView1.Columns[5].Width = 300;
            dataGridView1.Columns[6].Width = 300;


            bool isColorChanged = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                isColorChanged = !isColorChanged;
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                r.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                if (isColorChanged)
                    r.DefaultCellStyle.BackColor = Color.CadetBlue;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)//刪除鈕不做
        {

            //if (_position < 0)
            //    return;
            //DataRow row = (dataGridView1.DataSource as DataTable).Rows[_position];

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "DELETE * FROM tNproductvariants WHERE ";
            //SqlDataReader reader = cmd.ExecuteReader();
            //con.Close();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //string sql = "SELECT *FROM tNproductvariants WHERE ";
            //sql += "fName LIKE @K_KEYWORD ";
            //sql += "OR fMemo LIKE @K_KEYWORD";

            //displayNewProductvariantsBySql(sql, true);
        }

        private void txtKeyword_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            FrmProductvariantEditor f = new FrmProductvariantEditor();
            f.ShowDialog();

            if (f.isOK == DialogResult.OK)
            {

                (new CNProductManger()).create(f.newproductvariant);
                displayNewProductvariantsBySql("SELECT *FROM tNproductvariants", false);

            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (_position < 0)
                return;
            DataRow row = (dataGridView1.DataSource as DataTable).Rows[_position];

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tNproductvariants ";
            SqlDataReader reader = cmd.ExecuteReader();
            CNProductvariant x = null;
            if (reader.Read())
            {
                x = new CNProductvariant();
                x.fId = (int)reader["產品編號"];
                x.fsize = (int)reader["尺寸編號"];
                x.fcolor = (int)reader["顏色編號"];
                x.fthickness = (int)reader["厚度編號"];
                x.fgender = (int)reader["性別編號"];
                x.fstock = (int)reader["進貨量"];
            }
            con.Close();

            if (x == null)
                return;
            FrmProductvariantEditor f = new FrmProductvariantEditor();
            f.newproductvariant = x;
            f.ShowDialog();

            if (f.isOK == DialogResult.OK)
            {

                (new CNProductManger()).update(f.newproductvariant);
                displayNewProductvariantsBySql("SELECT *FROM tNproductvariants", false);
            }
        }

        private void FrmNewProductvariant_Load_1(object sender, EventArgs e)
        {
            displayNewProductvariantsBySql("SELECT * FROM tNproductvariants ", false);
        }

        private void FrmNewProductvariant_Paint_1(object sender, PaintEventArgs e)
        {
            resetGridstyle();
        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }
    }
}

