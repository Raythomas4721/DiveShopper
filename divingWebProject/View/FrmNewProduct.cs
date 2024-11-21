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
    public partial class FrmNewProduct : Form
    {
        SqlDataAdapter _da;
        SqlCommandBuilder _builder;
        int _position = -1;
        int _position2 = -1;
        DataSet _ds = null;


        public FrmNewProduct()
        {
            InitializeComponent();
        }

        private void FrmNewProduct_Load(object sender, EventArgs e)
        {
            displayNewProductBySql("SELECT * FROM tNproduct ", false);

        }
        private void displayNewProductBySql(string sql, bool isKeyword)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            con.Open();
            _da = new SqlDataAdapter(sql, con);

            if (isKeyword)
                _da.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD", "%" + (object)txtKeyword.Text + "%"));

            _builder = new SqlCommandBuilder();
            _builder.DataAdapter = _da;
            _ds = new DataSet();
            _da.Fill(_ds, "tNproduct");

            con.Close();
            dataGridView1.DataSource = _ds.Tables["tNproduct"];
            _da.Update(dataGridView1.DataSource as DataTable);

            foreach (DataRow row in _ds.Tables["tNproduct"].Rows)//右邊跑出圖片
            {
                CNProduct newproduct = new CNProduct();
                newproduct.fname = (string)row["產品名稱"];
                if (row["單價"] != DBNull.Value)
                    newproduct.fprice = Convert.ToDecimal(row["單價"]);

                if (row["照片"] != DBNull.Value)
                    newproduct.fImage = (byte[])row["照片"];
                NProductBox x = new NProductBox();
                x.newproduct = newproduct;
                flowLayoutPanel1.Controls.Add(x);
            }
            resetGridstyle1();
        }


        private void resetGridstyle1()
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
            //dataGridView1.Columns[5].Width = 300;

            bool isColorChanged1 = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                isColorChanged1 = !isColorChanged1;
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                r.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                if (isColorChanged1)
                    r.DefaultCellStyle.BackColor = Color.CadetBlue;
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)//新增
        {
            FrmNewProductEditor f = new FrmNewProductEditor();
            f.ShowDialog();

            if (f.isOK == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow row = dt.NewRow();
                row["產品編號"] = f.newproduct.fId;
                row["產品名稱"] = f.newproduct.fname;
                row["單價"] = f.newproduct.fprice;
                row["成本"] = f.newproduct.fcost;
                row["說明"] = f.newproduct.fmemo;
                row["照片"] = f.newproduct.fImage;
                dt.Rows.Add(row);
                _da.Update(dataGridView1.DataSource as DataTable);

            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)//查詢
        {

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.ColumnIndex == 0)
                        continue;
                    c.Style.BackColor = r.Cells[0].Style.BackColor;
                    if (c.Value.ToString().Contains(txtKeyword.Text))
                        c.Style.BackColor = Color.Red;
                }
            }
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)//刪除
        {
            if (_position < 0)
                return;
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow row = dt.Rows[_position];
            row.Delete();
            _da.Update(dataGridView1.DataSource as DataTable);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)//修改
        {
            if (_position < 0)
                return;
            DataRow row = (dataGridView1.DataSource as DataTable).Rows[_position];
            FrmNewProductEditor f = new FrmNewProductEditor();
            CNProduct x = new CNProduct();

            x.fId = (int)row["產品編號"];
            x.fname = (string)row["產品名稱"];
            if (row["說明"] != DBNull.Value)
                x.fmemo = (string)row["說明"];
            if (row["單價"] != DBNull.Value)
                x.fprice = Convert.ToDecimal(row["單價"]);
            if (row["成本"] != DBNull.Value)
                x.fcost = Convert.ToDecimal(row["成本"]);
            if (row["說明"] != DBNull.Value)
                x.fmemo = (string)row["說明"];
            if (row["照片"] != DBNull.Value)//如果資料庫裡不是NULL才讀
                x.fImage = (byte[])row["照片"];
            f.newproduct = x;
            f.ShowDialog();
            if (f.isOK == DialogResult.OK)
            {
                row["產品編號"] = f.newproduct.fId;
                row["產品名稱"] = f.newproduct.fname;
                row["說明"] = f.newproduct.fmemo;
                row["單價"] = f.newproduct.fprice;
                row["成本"] = f.newproduct.fcost;
                row["照片"] = f.newproduct.fImage;
            }
            _da.Update(dataGridView1.DataSource as DataTable);
            resetGridstyle1();
        }

        private void FrmNewProduct_Paint(object sender, PaintEventArgs e)
        {
            resetGridstyle1();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmNewProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            _da.Update(dataGridView1.DataSource as DataTable);

        }
    }
}
