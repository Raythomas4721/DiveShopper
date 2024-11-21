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
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNewOder f = new FrmNewOder();
        
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FrmCourseOrder f = new FrmCourseOrder();
            f.ShowDialog(); 
                   
           
        }

      
    }
}
