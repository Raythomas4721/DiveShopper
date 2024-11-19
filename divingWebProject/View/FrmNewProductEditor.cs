
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
using System.Windows.Forms;
using System.Xml.Linq;

namespace divingWebProject.View
{
    public partial class FrmNewProductEditor : Form
    {
        public FrmNewProductEditor()
        {
            InitializeComponent();
        }

        public DialogResult isOK { get; set; }
        private CNProduct _newproduct;
        public CNProduct newproduct
        {
            get
            {
                if (_newproduct == null)
                    _newproduct = new CNProduct();
                try
                {
                    _newproduct.fId = Convert.ToInt32(fbId.filedValue);
                }
                catch { }
                
                _newproduct.fname = fbName.filedValue;
                _newproduct.fmemo = fbMemo.filedValue;
                try
                {
                    _newproduct.fcost = Convert.ToDecimal(fbCost.filedValue.Trim());
                }
                catch { }
               
                try
                {
                    
                    _newproduct.fprice = Convert.ToDecimal(fbPrice.filedValue.Trim());
                }
                catch { }
           
                return _newproduct;
            }
            set
            {
                _newproduct = value;
                fbId.filedValue = _newproduct.fId.ToString();
                fbName.filedValue = _newproduct.fname;
                fbMemo.filedValue = _newproduct.fmemo;
                fbCost.filedValue= _newproduct.fcost.ToString();
                fbPrice.filedValue= _newproduct.fprice.ToString();
              
                if (_newproduct.fImage != null)
                {
                    try 
                    {
                        Stream streamImage = new MemoryStream(_newproduct.fImage);
                        pictureBox1.Image = Bitmap.FromStream(streamImage);

                    }
                    catch { }
                }
            }
        }


        private void nFieldBox2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmNewProductEditor_Load(object sender, EventArgs e)
        {

        }

        private void nFieldBox5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "潛水照片|*.png|潛水照片|*.jpg";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);

            FileStream imgstram = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(imgstram);
            this.newproduct.fImage = reader.ReadBytes((int)imgstram.Length);
            reader.Close();
            imgstram.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
            this.isOK = DialogResult.OK;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmNewProductvariant f = new FrmNewProductvariant();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

