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
    public partial class FrmNewOder : Form
    {
        SqlDataAdapter _da;
        SqlCommandBuilder _builder;
        public FrmNewOder()
        {
            InitializeComponent();
        }

       

        private void FrmNewOder_Load(object sender, EventArgs e)
        {
            SqlConnection con= new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            con.Open();
            _da = new SqlDataAdapter("SELECT * FROM tNorder", con);
            _builder = new SqlCommandBuilder();
            _builder.DataAdapter = _da;
            DataSet ds=new DataSet();
            _da.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void toolStripButton1_Click(object sender, EventArgs e)//新增按鈕
        {
            FrmNewOder f=new FrmNewOder();
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow row = dt.NewRow();
            row["orderId"] = f.forderid;
            row["discountValue"] = f.fdiscount;
            row["subtotal"] = f.fsubtotal;
            //row["quantity"] = f.room.fCost;
            dt.Rows.Add(row);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//確認按鈕
        {
            FrmNewOder f = new FrmNewOder();
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow row = dt.NewRow();
            row["orderId"] = f.forderid;
            row["discountValue"] = f.fdiscount;
            row["subtotal"] = f.fsubtotal;
            //row["quantity"] = f.room.fCost;
            dt.Rows.Add(row);
        }
    }
}
