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
    public partial class FrmCoachList : Form
    {
        int _position = -1;
        SqlDataAdapter _da;
        SqlCommandBuilder _builder;
        public FrmCoachList()
        {
            InitializeComponent();
        }

        private void FrmCoachList_Load(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 50;
            displayMemberBySql("SELECT * FROM tMcoaches", false);
        }
        private void displayMemberBySql(string sql, bool isKeyWord)
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
            con.Close();
        }
        private void resetGridStyle()
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 250;
            dataGridView1.Columns[4].Width = dataGridView1.Width - 700 - dataGridView1.RowHeadersWidth;
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

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCoachList_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }
    }
}
