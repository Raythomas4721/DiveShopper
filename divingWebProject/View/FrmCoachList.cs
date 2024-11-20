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
            dataGridView1.Columns["Photo"].Visible = false;
            dataGridView1.Columns["divingStyleId"].Visible = false;
            con.Close();
        }
        private void resetGridStyle()
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 300;
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
            FrmMcoachEditor f = new FrmMcoachEditor();
            f.ShowDialog();
            if (f.isOK == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow row = dt.NewRow();
                row["coachName"] = f.coach.coachName;
                row["gender"] = f.coach.gender;
                row["coachPhone"] = f.coach.coachPhone;
                row["experience"] = f.coach.experience;

                dt.Rows.Add(row);
                _da.Update(dt);
            }
        }

        private void FrmCoachList_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
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

        private void FrmCoachList_FormClosed(object sender, FormClosedEventArgs e)
        {
            _da.Update(dataGridView1.DataSource as DataTable);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;
            DataRow row = (dataGridView1.DataSource as DataTable).Rows[_position];
            FrmMcoachEditor f = new FrmMcoachEditor();
            CMcoaches x = new CMcoaches();
            x.coachName = (string)row["coachName"];
            x.gender = (string)row["gender"];
            x.coachPhone = (string)row["coachPhone"];
            x.experience = (string)row["experience"];
            if (row["Photo"] != DBNull.Value)
                x.photo = (byte[])row["photo"];
            f.coach = x;
            f.ShowDialog();
            if (x == null) { return; }
            if (f.isOK == DialogResult.OK)
            {
                row["coachName"] = f.coach.coachName;
                row["gender"] = f.coach.gender;
                row["coachPhone"] = f.coach.coachPhone;
                row["experience"] = f.coach.experience;
                row["photo"] = f.coach.photo;

                _da.Update((DataTable)dataGridView1.DataSource);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
