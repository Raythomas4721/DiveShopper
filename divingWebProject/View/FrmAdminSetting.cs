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
    public partial class FrmAdminSetting : Form
    {
        int _position = -1;
        SqlDataAdapter _da;
        SqlCommandBuilder _builder;
        public FrmAdminSetting()
        {
            InitializeComponent();
        }

        private void FrmAdminSetting_Load(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 50;
            //dataGridView1.ColumnHeadersHeight = 100;
            displayAdminBySql("SELECT * FROM tMadmin", false);
        }
        private void displayAdminBySql(string sql, bool isKeyWord)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            con.Open();

            _da = new SqlDataAdapter(sql, con);
            if (isKeyWord)
            {
                _da.SelectCommand.Parameters.Add(new SqlParameter("K_Keyword", "%" + (object)toolStripTextBox1.Text + "%"));
            }

            _builder = new SqlCommandBuilder();
            _builder.DataAdapter = _da;


            DataSet ds = new DataSet();
            _da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["passwordHash"].Visible = false;
            con.Close();
        }
        private void resetGridStyle()
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 250;
            bool isColorChanged = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                isColorChanged = !isColorChanged;
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                r.DefaultCellStyle.BackColor = Color.AliceBlue;
                if (isColorChanged)
                {
                    r.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void FrmAdminSetting_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmMadminEditor f = new FrmMadminEditor();
            f.ShowDialog();
            if (f.isOK == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow row = dt.NewRow();
                row["userName"] = f.admin.userName;
                row["email"] = f.admin.email;
                row["passwordHash"] = f.admin.passwordHash;
                row["roleName"] = f.admin.roleName;
                row["createAt"] = DateTime.Now;
                row["lastLogin"] = DateTime.Now;

                dt.Rows.Add(row);
                _da.Update(dt);
            }
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

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;
            DataRow row = (dataGridView1.DataSource as DataTable).Rows[_position];
            FrmMadminEditor f = new FrmMadminEditor();
            CMadmin x = new CMadmin();
            x.userName = (string)row["userName"];
            x.email = (string)row["email"];
            x.passwordHash = (string)row["passwordHash"];
            x.lastLogin = (DateTime)row["lastLogin"];
            x.roleName = (string)row["roleName"];
            f.admin = x;
            f.ShowDialog();
            if (x == null) { return; }
            if (f.isOK == DialogResult.OK)
            {
                row["userName"] = f.admin.userName;
                row["email"] = f.admin.email;
                row["passwordHash"] = f.admin.passwordHash;
                row["lastLogin"] = DateTime.Now;
                row["roleName"] = f.admin.roleName;

                _da.Update((DataTable)dataGridView1.DataSource);
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void FrmAdminSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            _da.Update(dataGridView1.DataSource as DataTable);
        }
    }
}
