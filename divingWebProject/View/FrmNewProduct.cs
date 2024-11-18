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
        private CNProduct _selected;
        SqlDataAdapter _da;
        SqlCommandBuilder _builder;
        int _position = -1;
        DataSet _ds = null;
      

        public FrmNewProduct()
        {
            InitializeComponent();
        }

        private void FrmNewProduct_Load(object sender, EventArgs e)
        {
            displayNewProductBySql("SELECT * FROM tNproduct", false);

            foreach (DataRow row in _ds.Tables[0].Rows)//右邊跑出圖片
            {
                CNProduct newproduct = new CNProduct();
                newproduct.fname = (string)row["productname"];
                if (row["Unitprice"] != DBNull.Value)
                    newproduct.fprice = Convert.ToDecimal(row["Unitprice"]);
                
                if (row["picture"] != DBNull.Value)
                    newproduct.fImage = (byte[])row["picture"];
                NProductBox x = new NProductBox();
                x.newproduct = newproduct;
                flowLayoutPanel1.Controls.Add(x);
            }

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
            _da.Fill(_ds);
            con.Close();
            dataGridView1.DataSource = _ds.Tables[0];
            _da.Update(dataGridView1.DataSource as DataTable);
            resetGridstyle();

        }

        private void resetGridstyle()
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].Width = 300;

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
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmNewProductEditor f = new FrmNewProductEditor();
            f.ShowDialog();

            if (f.isOK == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow row = dt.NewRow();

                row["productName"] = f.newproduct.fname;
                row["unitPrice"] = f.newproduct.fprice;
                row["unitCost"] = f.newproduct.fcost;
                row["description"] = f.newproduct.fmemo;
                row["picture"] = f.newproduct.fImage;
                //row["size"] = f.newproduct.fsize;
                //row["color"] = f.newproduct.fcolor;
                //row["gender"] = f.newproduct.fgender;
                //row["thickness"] = f.newproduct.fthickness;
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
        private void ordernewproduct(CNProduct p)
        {
            _selected = p;
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;
            DataRow row = (dataGridView1.DataSource as DataTable).Rows[_position];
            FrmNewProductEditor f = new FrmNewProductEditor();
            CNProduct x = new CNProduct();
            x.fname = (string)row["productName"];
            if (row["description"] != DBNull.Value)
                x.fmemo = (string)row["description"];
           if(row["unitPrice"] != DBNull.Value)
            x.fprice = Convert.ToDecimal(row["unitPrice"]);
            if (row["unitCost"] != DBNull.Value)
                x.fcost = Convert.ToDecimal(row["unitCost"]);
            if (row["description"] != DBNull.Value)
                x.fmemo = (string)row["description"];
            ////x.fcolorId = (int)row["colorId"];
            ////x.fthicknessId = (int)row["thicknessId"];
            ////x.fsizeId = (int)row["sizeId"];
            ////x.fgenderId = (int)row["genderId"];

            if (row["picture"] != DBNull.Value)//如果資料庫裡不是NULL才讀
                x.fImage = (byte[])row["picture"];
            f.newproduct = x;
            f.ShowDialog();
            if (f.isOK == DialogResult.OK)
            {
                row["productName"] = f.newproduct.fname;
                row["description"] = f.newproduct.fmemo;
                row["unitPrice"] = f.newproduct.fprice;
                row["unitCost"] = f.newproduct.fcost;
                //row["colorId"] = f.newproduct.fcolorId;
                //row["thicknessId"] = f.newproduct.fthicknessId;
                //row["sizeId"] = f.newproduct.fsizeId;
                //row["genderId"] = f.newproduct.fgenderId;
                row["picture"] = f.newproduct.fImage;
            }
            _da.Update(dataGridView1.DataSource as DataTable);
        

        }

        private void FrmNewProduct_Paint(object sender, PaintEventArgs e)
        {
            resetGridstyle();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
