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
    public partial class FrmForgetPassword : Form
    {
        public FrmForgetPassword()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FieldBox1_Load(object sender, EventArgs e)
        {

        }

        private void FieldBox2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = FieldBox1.filedValue;
            string email = FieldBox2.filedValue;

            if (verifyAccountEmail(userName, email))
            {
                string tempPassword = newTemporaryPassword(userName);
                MessageBox.Show($"臨時密碼為：{tempPassword}\n請登入並立即更改密碼。", "密碼重設成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("帳號或電子郵件不正確，請重新輸入！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool verifyAccountEmail(string userName, string email)
        {
            string sql = "SELECT COUNT(*) FROM tMadmin WHERE userName = @userName AND email = @Email";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = (@"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@Email", email);

            int count = (int)cmd.ExecuteScalar();

            return count > 0;
        }
        private string newTemporaryPassword(string userName)
        {
            string tempPassword = Guid.NewGuid().ToString().Substring(0, 5); // 產生一組5位隨機密碼
            string sql = "UPDATE tMadmin SET passwordHash = @passwordHash WHERE userName = @userName";

            SqlConnection con = new SqlConnection();
            con.ConnectionString =(@"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;");
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@passwordHash", tempPassword); 
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.ExecuteNonQuery();

            return tempPassword;
        }
    }
}
