using divingWebProject.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace divingWebProject.View
{
    public partial class FrmSiteEditor : Form
    {
        public DialogResult isOk { get; set; }
        
        private CSite _site;
        public CSite site 
        {  
           get { 
                if (_site == null)
                    _site = new CSite();
                _site.siteId = Convert.ToInt32(memberFieldBox6.filedValue);
                _site.venueName = (memberFieldBox1.filedValue);
                _site.numberOfPeople = Convert.ToInt32(memberFieldBox2.filedValue);
                _site.venueAddress = (memberFieldBox3.filedValue);
                _site.detail = (memberFieldBox4.filedValue);
                _site.state = (memberFieldBox5.filedValue);
                return _site;

            }
            set
            {
                _site = value;
                memberFieldBox6.filedValue = _site.siteId.ToString();
                memberFieldBox1.filedValue = _site.venueName;
                memberFieldBox2.filedValue = _site.numberOfPeople.ToString();
                memberFieldBox3.filedValue = _site.venueAddress;
                memberFieldBox4.filedValue = _site.detail;
                memberFieldBox5.filedValue = _site.state;
            }
        }
        public FrmSiteEditor()
        {
            InitializeComponent();
        }

        private void memberFieldBox2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "";
            if (string.IsNullOrEmpty(memberFieldBox1.filedValue))
                message += "\r\n房型不可空白";
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
                return;
            }

            this.isOk = DialogResult.OK;
            Close();
        }
        public CSite Sitename 
        {
            get
            {
                if (_site == null)
                    _site = new CSite();
                
                _site.venueName = memberFieldBox1.filedValue;
                _site.numberOfPeople = Convert.ToInt32(memberFieldBox2.filedValue);
                _site.venueAddress = memberFieldBox3.filedValue;
                _site.detail = memberFieldBox4.filedValue;
                _site.state = memberFieldBox5.filedValue;
                return _site;
            }
            set
            {
                _site = value;

                memberFieldBox1.filedValue = _site.venueName;
                memberFieldBox2.filedValue = _site.numberOfPeople.ToString();
                memberFieldBox3.filedValue = _site.venueAddress;
                memberFieldBox4.filedValue = _site.detail;
                memberFieldBox5.filedValue = _site.state;
            }
           }

        private void memberFieldBox1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "房間照片|*.png";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);

        }
    }

}
