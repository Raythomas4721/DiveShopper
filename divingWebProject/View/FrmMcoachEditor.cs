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
    public partial class FrmMcoachEditor : Form
    {
        public DialogResult isOK { get; set; }
        private CMcoaches _coach;
        public FrmMcoachEditor()
        {
            InitializeComponent();
        }
        public CMcoaches coach
        {
            get
            {
                if (_coach == null)
                {
                    _coach = new CMcoaches();
                }

                _coach.coachName = coachFieldBox1.filedValue;
                _coach.gender = coachFieldBox2.filedValue;
                _coach.experience = richTextBox1.Text;


                return _coach;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isOK = DialogResult.OK; 
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
