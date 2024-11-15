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
            dataGridView1.Columns[1].Width =200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].Width = 300;

            bool isColorChanged=false;   
            foreach(DataGridViewRow r in dataGridView1.Rows)
            {
                isColorChanged =! isColorChanged;
                r.DefaultCellStyle.Font = new Font("微軟正黑體",14);
                r.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                if(isColorChanged )
                    r.DefaultCellStyle.BackColor= Color.CadetBlue;
            
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
                //row["size"] = f.newproduct.fsize;
                //row["color"] = f.newproduct.fcolor;
                //row["gender"] = f.newproduct.fgender;
                //row["thickness"] = f.newproduct.fthickness;
                row["picture"] = f.newproduct.fImage;
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
                    if (c.Value.ToString() .Contains( txtKeyword.Text))
                        c.Style.BackColor = Color.Red;
                
                }
            
            }
            
            //flowLayoutPanel1.Controls.Clear();
            //string sql = "SELECT *FROM tNproduct WHERE ";
            //sql += "productName LIKE @K_KEYWORD ";

            //displayNewProductBySql(sql, true);


            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            //con.Open();
            //SqlDataAdapter da = new SqlDataAdapter(sql, con);
            //da.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD",
            //        "%" + (object)txtKeyword + "%"));

            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //con.Close();

            //foreach (DataRow row in ds.Tables[0].Rows)
            //{
            //    CNProduct newproduct = new CNProduct();
            //    newproduct.fname = (string)row["productName"];
            //    newproduct.fprice = Convert.ToDecimal(row["unitPrice"]);
               
                
            //    if (row["picture"] != DBNull.Value)
            //        newproduct.fImage = (byte[])row["picture"];


            //    NProductBox x = new NProductBox();
            //    x.newproduct = newproduct;
            //    x.orderproduct+= this.ordernewproduct;
            //    flowLayoutPanel1.Controls.Add(x);
            //}
            ////for (int i = 0;i<8;i++)
            ////{

            ////    NProductBox x = new NProductBox();
            ////    x.Width = 250;
            ////    x.Height = 200;
            ////    x.BackColor = Color.White;

            ////    flowLayoutPanel1.Controls.Add(x);

            ////}


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
            DataTable dt=dataGridView1.DataSource as DataTable;
            DataRow row = dt.Rows[_position];
            row.Delete();
            _da.Update(dataGridView1.DataSource as DataTable);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;
            DataRow row =(dataGridView1.DataSource as DataTable).Rows[_position];
            FrmNewProductEditor f= new FrmNewProductEditor();
            CNProduct x = new CNProduct();
            x.fname = (string)row["productName"];
            //f.newproduct.fprice = Convert.ToDecimal(row["unitPrice"]);
            //f.newproduct.fImage= (byte[])row["picture"] ;
            f.newproduct = x;
            f.ShowDialog();
            if(f.isOK== DialogResult.OK)
            {
                row["productName"] = f.newproduct.fname;



            }
        }

        private void FrmNewProduct_Paint(object sender, PaintEventArgs e)
        {
            resetGridstyle();
        }
    }
    } 
