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
    public partial class FrmSite : Form
    {
        SqlDataAdapter _da;
        DataSet _ds = null;
        SqlCommandBuilder _builder;
        int _position = -1;
        public FrmSite()
        {
            InitializeComponent();
        }

        private void FrmSite_Load(object sender, EventArgs e)
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

            resetGridStyle();
        }

        private void resetGridStyle()
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 210;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 530;
            dataGridView1.Columns[4].Width = 530;
            dataGridView1.Columns[5].Width = dataGridView1.Width - 100 - 120 - 210 -530*2 - dataGridView1.RowHeadersWidth;
            //dataGridView1.Columns[5].Width = dataGridView1.Width - 70 - 200 - 100 * 3 - dataGridView1.RowHeadersWidth;
            bool isColorChanged = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                isColorChanged = !isColorChanged;

                r.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                r.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                if (isColorChanged)
                    r.DefaultCellStyle.BackColor = Color.FromArgb(238, 238, 242);
            }
            dataGridView1.Columns["venueName"].HeaderText = "場地名稱";
            dataGridView1.Columns["numberOfPeople"].HeaderText = "場地人數";
            dataGridView1.Columns["venueAddress"].HeaderText = "場地地址";
            dataGridView1.Columns["detail"].HeaderText = "描述";
            dataGridView1.Columns["state"].HeaderText = "狀態";
            dataGridView1.Columns["siteId"].HeaderText = "場地ID";

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

        private void FrmSite_FormClosed(object sender, FormClosedEventArgs e)
        {
            _da.Update(dataGridView1.DataSource as DataTable);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
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
                //row["siteId"] = f.site.siteId;


            }
                Close();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSite_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.ColumnIndex == 0)
                        continue;
                    c.Style.BackColor = r.Cells[0].Style.BackColor;
                    if (c.Value.ToString().Contains(toolStripTextBox1.Text))
                        c.Style.BackColor = Color.Yellow;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }
    }
}
