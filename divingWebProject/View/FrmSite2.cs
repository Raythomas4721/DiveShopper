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
    public partial class FrmSite2 : Form
    {
        SqlDataAdapter _da;
        DataSet _ds = null;
        SqlCommandBuilder _builder;
        int _position = -1;
        public FrmSite2()
        {
            InitializeComponent();
        }

        private void FrmSite2_Load(object sender, EventArgs e)
        {
            displaySiteBySql("SELECT * FROM tSsiteDetail", false);
        }

        private void displaySiteBySql(string sql,bool isKeyword)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            con.Open();
            _da = new SqlDataAdapter(sql, con);
            if(isKeyword)
                _da.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD",
                    "%"+(object)toolStripTextBox1+"%"));
            _builder = new SqlCommandBuilder();
            _builder.DataAdapter = _da;

            DataSet ds = new DataSet();
            _da.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmSiteEditor f = new FrmSiteEditor();
            
            f.ShowDialog();
            if (f.isOk == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow row = dt.NewRow();
                row["venueName"] = f.site.venueName;
                row["numberOfPeople"] = f.site.numberOfPeople;
                row["venueAddress"] = f.site.venueAddress;
                row["detail"] = f.site.detail;
                row["state"] = f.site.state;
                dt.Rows.Add(row);
                //    (new CSiteMangers()).create(f.CSite);
                //    displayCustomersBySql("SELECT * FROM tCustomer", false);

            }
        }

        private void FrmSite2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _da.Update(dataGridView1.DataSource as DataTable);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow row = dt.Rows[_position];
            row.Delete();
            _da.Update(dataGridView1.DataSource as DataTable);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;
            DataRow row = (dataGridView1.DataSource as DataTable).Rows[_position];
            FrmSiteEditor f = new FrmSiteEditor();
            CSite x = new CSite();
            x.venueName = row["venueName"].ToString();
            x.numberOfPeople = Convert.ToInt32(row["numberOfPeople"]);
            x.venueAddress = row["venueAddress"].ToString();
            x.detail = row["detail"].ToString();
            x.state = row["state"].ToString();
            f.site = x;
            f.ShowDialog();
            if (f.isOk == DialogResult.OK)
            {

                row["venueName"] = f.site.venueName;
                row["numberOfPeople"] = f.site.numberOfPeople;
                row["venueAddress"] = f.site.venueAddress;
                row["detail"] = f.site.detail;
                row["state"] = f.site.state;


            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tSsiteDetail WHERE ";
            sql += " venueName LIKE @K_KEYWORD";
          
            sql += " OR venueAddress LIKE @K_KEYWORD";
            sql += " OR detail LIKE @K_KEYWORD";
            sql += " OR state LIKE @K_KEYWORD";
            


            displaySiteBySql(sql, true);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;
            DataRow row = (dataGridView1.DataSource as DataTable).Rows[_position];
            FrmSiteEditor f = new FrmSiteEditor();
            CSite x = new CSite();
            x.venueName = row["venueName"].ToString();
            x.numberOfPeople = Convert.ToInt32(row["numberOfPeople"]);
            x.venueAddress = row["venueAddress"].ToString();
            x.detail = row["detail"].ToString();
            x.state = row["state"].ToString();
            f.site = x;
            
            if (f.isOk == DialogResult.OK)
            {

                row["venueName"] = f.site.venueName;
                row["numberOfPeople"] = f.site.numberOfPeople;
                row["venueAddress"] = f.site.venueAddress;
                row["detail"] = f.site.detail;
                row["state"] = f.site.state;


            }
            Close();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
