﻿using divingWebProject.Modal;
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
    public partial class FrmMLogin : Form
    {
        private bool isClosed = true;
        public FrmMLogin()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            string sql = "select * from tMadmin where ";
            sql += " userName = @K_email ";
            sql += " and passwordHash = @K_passwordHash";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add(new SqlParameter("K_email", (object)FieldBox1.filedValue));
            cmd.Parameters.Add(new SqlParameter("K_passwordHash", (object)FieldBox2.filedValue));
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                isClosed = false;
                Close();
            }
            else
                MessageBox.Show("帳密不符");
        }

        private void FrmMLogin_Load(object sender, EventArgs e)
        {
            FieldBox2.passwordMask = '*';
        }

        private void FrmMLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = isClosed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isClosed=false;
            Application.Exit();
        }

        private void memberFieldBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void memberFieldBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FrmMLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmMLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                login();
            }
        }
    }
}
