using divingWebProject.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace divingWebProject.View
{
    public partial class FrmMadminEditor : Form
    {
        public DialogResult isOK { get; set; }
        private CMadmin _admin;
        public FrmMadminEditor()
        {
            InitializeComponent();
        }
        public CMadmin admin
        {
            get
            {
                if (_admin  == null)
                {
                    _admin = new CMadmin();
                }

                _admin.userName = FieldBox1.filedValue;
                _admin.email = FieldBox2.filedValue;
                _admin.passwordHash = FieldBox3.filedValue;
                if (comboBox1.SelectedItem == null)
                    MessageBox.Show("請選擇管理角色");
                _admin.roleName = comboBox1.SelectedItem.ToString(); 
                _admin.lastLogin = DateTime.Today;


                return _admin;
            }
            set
            {
                _admin = value;
                FieldBox1.filedValue = _admin.userName;
                FieldBox2.filedValue = _admin.email;
                FieldBox3.filedValue = _admin.passwordHash;
                //comboBox1.SelectedValue = _admin.roleName;
                if (comboBox1.DataSource != null) 
                {
                    comboBox1.SelectedValue = _admin.roleName;
                }
                else
                {
                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString() == _admin.roleName)
                        {
                            comboBox1.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FieldBox1.filedValue))
            {
                MessageBox.Show("帳號不可為空");
                return;
            }
            //if (string.IsNullOrEmpty(FieldBox2.filedValue))
            //{
            //    MessageBox.Show("電子郵件不可為空");
            //    return;
            //}
            if (string.IsNullOrWhiteSpace(FieldBox3.filedValue) || (FieldBox3.filedValue != FieldBox4.filedValue))
            {
                MessageBox.Show("密碼欄位有誤，請輸入相同的值");
                return;
            }
            this.isOK = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
