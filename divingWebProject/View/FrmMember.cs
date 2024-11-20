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
    public partial class FrmMember : Form
    {
        int _position = -1;
        SqlDataAdapter _da;
        SqlCommandBuilder _builder;
        public FrmMember()
        {
            InitializeComponent();
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 50;
            //dataGridView1.ColumnHeadersHeight = 100;
            displayMemberBySql("SELECT * FROM tMmemberList", false);
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
            dataGridView1.Columns["memberPhoto"].Visible = false;
            dataGridView1.Columns["memberPassword"].Visible = false;
            dataGridView1.Columns["urgentContact"].Visible = false;
            dataGridView1.Columns["urgentPhone"].Visible = false;
            dataGridView1.Columns["recentLogin"].Visible = false;
            con.Close();
        }
        private void resetGridStyle()
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 250;
            //dataGridView1.Columns[5].Width = 350;

            //dataGridView1.Columns[10].Width = dataGridView1.Width - 1050 - dataGridView1.RowHeadersWidth;
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

        private void FrmMember_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmMmemberEditor f = new FrmMmemberEditor();
            f.ShowDialog();
            if (f.isOK == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow row = dt.NewRow();
                row["memberName"] = f.member.memberName;
                row["memberGender"] = f.member.memberGender;
                row["memberPhone"] = f.member.memberPhone;
                row["memberEmail"] = f.member.memberEmail;
                row["memberAddress"] = f.member.memberAddress;
                row["memberPassword"] = f.member.memberPassword;
                row["urgentContact"] = f.member.urgentContact;
                row["urgentPhone"] = f.member.urgentPhone;
                row["recentLogin"] = DateTime.Now;
                row["status"] = "active";

                dt.Rows.Add(row);
                _da.Update(dt);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayMemberBySql("SELECT * FROM tMmemberList", false);
        }

        private void FrmMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            _da.Update(dataGridView1.DataSource as DataTable);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (_position < 0)
                return;


            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow row = dt.Rows[_position];

            // 從 DataRow 中提取 memberId
            string memberId = row["memberId"].ToString();

            // 檢查是否存在關聯資料
            string query = $"SELECT COUNT(1) FROM tUproducts WHERE sellerId = @memberId";
            int relatedCount = 0;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@memberId", memberId);
            relatedCount = (int)cmd.ExecuteScalar();


            if (relatedCount > 0)
            {
                // 有關聯資料，更新會員狀態為 inactive
                row["status"] = "inactive";
            }
            else
            {
                // 無關聯資料，刪除會員
                row.Delete();
            }
            _da.Update(dataGridView1.DataSource as DataTable);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            editMember();
        }

        private void editMember()
        {
            if (_position < 0)
                return;
            DataRow row = (dataGridView1.DataSource as DataTable).Rows[_position];
            FrmMmemberEditor f = new FrmMmemberEditor();
            CMmember x = new CMmember();
            x.memberName = (string)row["memberName"];
            x.memberGender = (string)row["memberGender"];
            x.memberPhone = (string)row["memberPhone"];
            x.memberEmail = (string)row["memberEmail"];
            x.memberAddress = (string)row["memberAddress"];
            x.memberPassword = (string)row["memberPassword"];
            x.urgentContact = (string)row["urgentContact"];
            x.urgentPhone = (string)row["urgentPhone"];
            x.recentLogin = (DateTime)row["recentLogin"];
            if (row["memberPhoto"] != DBNull.Value)
                x.memberPhoto = (byte[])row["memberPhoto"];
            x.status = (string)row["status"];
            f.member = x;
            f.ShowDialog();
            if (x == null) { return; }
            if (f.isOK == DialogResult.OK)
            {
                row["memberName"] = f.member.memberName;
                row["memberGender"] = f.member.memberGender;
                row["memberPhone"] = f.member.memberPhone;
                row["memberEmail"] = f.member.memberEmail;
                row["memberAddress"] = f.member.memberAddress;
                row["memberPassword"] = f.member.memberPassword;
                row["urgentContact"] = f.member.urgentContact;
                row["urgentPhone"] = f.member.urgentPhone;
                row["recentLogin"] = DateTime.Now;
                row["memberPhoto"] = f.member.memberPhoto;
                row["status"] = f.member.status;

                _da.Update((DataTable)dataGridView1.DataSource);
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            editMember();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string sql = "select * from tMmemberList where ";
            sql += " memberName like @K_keyword ";
            sql += " or memberPhone like @K_keyword";
            sql += " or memberEmail like @K_keyword";
            displayMemberBySql(sql, true);
        }
    }
}
