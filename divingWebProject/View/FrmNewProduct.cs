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
        DataSet _ds = null;

        public FrmNewProduct()
        {
            InitializeComponent();
        }

        private void FrmNewProduct_Load(object sender, EventArgs e)
        {
            displayNewProductBySql("SELECT p.productName, p.unitPrice,p.unitCost,p.picture,v.stock FROM tNproduct p JOIN tNproductvariants  v ON p.productId=v.productId JOIN tNsize s on v.sizeId=s.sizeId", false);

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
                row["size"] = f.newproduct.fsize;
                row["color"] = f.newproduct.fcolor;
                row["gender"] = f.newproduct.fgender;
                row["thickness"] = f.newproduct.fthickness;
                row["picture"] = f.newproduct.fImage;
                dt.Rows.Add(row);
            }
        }
            private void toolStripButton3_Click(object sender, EventArgs e)
            {
            //string sql = "SELECT *FROM tNproduct WHERE ";
            //sql += "productName LIKE @K_KEYWORD ";
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            //con.Open();

            //SqlDataAdapter da = new SqlDataAdapter(sql, con);

            //da.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD", "%" + (object)txtKeyword.Text + "%"));

            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //con.Close();

            for (int i = 0;i<8;i++)
            {
               
                NProductBox x = new NProductBox();
                x.Width = 250;
                x.Height = 200;
                x.BackColor = Color.White;

               

                

                flowLayoutPanel1.Controls.Add(x);

            }


        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }
    }
    } 
