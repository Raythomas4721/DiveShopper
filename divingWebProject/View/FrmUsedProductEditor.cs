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

namespace divingWebProject.View
{
    public partial class FrmUsedProductEditor : Form
    {
        public FrmUsedProductEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "照片|*.png|照片|*.jpg";
            //if (openFileDialog1.ShowDialog() != DialogResult.OK)
            //    return;
            //pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);

            //FileStream imgStram = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            //BinaryReader reader = new BinaryReader(imgStram);
            //this.room.fImage = reader.ReadBytes((int)imgStram.Length);
            //reader.Close();
            //imgStram.Close();
        }
    }
}
