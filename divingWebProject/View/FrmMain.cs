using Sunny.UI;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            FrmUsedProduct f = new FrmUsedProduct();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmMember f = new FrmMember();
            f.MdiParent = this;
            f.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmMLogin f = new FrmMLogin();
            f.ShowDialog();
            // 獲取登入的使用者名稱
            string userName = "登出" + f.CurrentUserName ;
            if (userName == null)
                userName = "登出使用者";
            toolStripButton10.Text = userName; 

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            FrmNewProduct f = new FrmNewProduct();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FrmCourse f = new FrmCourse();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmSite f = new FrmSite();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmOrder f = new FrmOrder();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            FrmReview f = new FrmReview();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton9_Click_1(object sender, EventArgs e)
        {
            FrmCoachList f = new FrmCoachList();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            FrmAdminSetting f = new FrmAdminSetting();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            FrmMLogin f = new FrmMLogin();
            f.ShowDialog();
        }
    }
}
