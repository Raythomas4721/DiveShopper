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

namespace divingWebProject.Modal
{
    public delegate void DProductClick(CNProduct p);
    public partial class NProductBox : UserControl
    {
        
        //public event DProductClick orderproduct;//用delegate 創造事件
        private CNProduct _newproduct;
        public NProductBox()
        {
            InitializeComponent();
        }
        
        public CNProduct newproduct
        {
            get { return _newproduct; }

            set
            {
                _newproduct = value;
                label1NAME.Text = _newproduct.fname;
                label3PRICE.Text = _newproduct.fprice.ToString();
                if (_newproduct.fImage == null) // 檢查 fImage 是否為 null
                    return;

                    Stream s = new MemoryStream(_newproduct.fImage);
                    pictureBox2.Image = Bitmap.FromStream(s);
                
              
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //if (orderproduct != null)
            //    orderproduct(this._newproduct);
        }

        private void NProductBox_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void lblName_Click(object sender, EventArgs e)
        //{
        //    if (orderRoom != null)
        //        orderRoom(this._room);
        //}

        //private void lblMemo_Click(object sender, EventArgs e)
        //{
        //    if (orderRoom != null)
        //        orderRoom(this._room);
        //}

        //private void lblPrice_Click(object sender, EventArgs e)
        //{
        //    if (orderRoom != null)
        //        orderRoom(this._room);
        //}

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    if (orderRoom != null)
        //        orderRoom(this._room);
        //}
    }
}
