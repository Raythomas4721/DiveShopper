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
    public partial class FrmCourseOrder : Form
    {
        public FrmCourseOrder()
        {
            InitializeComponent();
        }

        private void FrmCourseOrder_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.FromArgb(108, 122, 137);
            toolStrip1.BackColor = System.Drawing.Color.FromArgb(163, 198, 196);
            
            
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); //奇數行
        }

    }
}
