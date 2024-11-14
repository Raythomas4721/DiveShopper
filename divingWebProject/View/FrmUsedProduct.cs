using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace divingWebProject.View
{
    public partial class FrmUsedProduct : Form
    {
        public FrmUsedProduct()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)  //新增
        {
            FrmUsedProductEditor f = new FrmUsedProductEditor();
            f.ShowDialog();
        }
    }
}
