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


        private void resetGridstyle()
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].Width = 300;
            dataGridView1.Columns[4].Width = 300;
            dataGridView1.Columns[5].Width = 300;
          

            dataGridView1.Columns["productvariantsId"].HeaderText = "進貨ID";
            dataGridView1.Columns["productId"].HeaderText = "產品ID";
            dataGridView1.Columns["sizeId"].HeaderText = "尺寸編號";
            dataGridView1.Columns["colorId"].HeaderText = "顏色編號";
            dataGridView1.Columns["thicknessId"].HeaderText = "厚度編號";
            dataGridView1.Columns["genderId"].HeaderText = "性別編號";
            dataGridView1.Columns["stock"].HeaderText = "進貨量";

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

        private void toolStripButton1_Click_1(object sender, EventArgs e)//修改
        {

            if (_position < 0)
                return;
            DataRow row = (dataGridView1.DataSource as DataTable).Rows[_position];
            int productId = (int)row["productId"];

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tNproductvariants WHERE productId= @K_FID ";
            cmd.Parameters.AddWithValue("@K_FID", productId);
            SqlDataReader reader = cmd.ExecuteReader();
            CNProductvariant x = null;
            int fid=0;
            if (reader.Read())
            {
                x = new CNProductvariant();
                x.fId = (int)reader["productId"];
                x.fsize = (int)reader["sizeId"];
                x.fcolor = (int)reader["colorId"];
                x.fthickness = (int)reader["thicknessId"];
                x.fgender = (int)reader["genderId"];
                x.fstock = (int)reader["stock"];
                fid = (int)reader["productvariantsId"];
            }
            con.Close();

            if (x == null)
                return;
            FrmProductvariantEditor f = new FrmProductvariantEditor();
            f.newproductvariant = x;
            f.ShowDialog();

            if (f.isOK == DialogResult.OK)
            {
                (new CNProductManger()).update(f.newproductvariant,fid);
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

