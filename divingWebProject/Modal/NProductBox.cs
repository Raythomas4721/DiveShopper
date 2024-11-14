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
    public delegate void DRoomClick(CNProduct p);
    public partial class NProductBox : UserControl
    {
        private CNProduct _newproduct;
        public NProductBox()
        {
            InitializeComponent();
        }


        public event DRoomClick orderRoom;//用delegate 創造事件

        public CNProduct newproduct
        {
            get { return _newproduct; }

            set
            {
                _newproduct = value;
                label1NAME.Text = _newproduct.fname;
                label3PRICE.Text = _newproduct.fprice.ToString();
                Stream s = new MemoryStream(_newproduct.fImage);
                pictureBox1.Image = Bitmap.FromStream(s);

            }
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
