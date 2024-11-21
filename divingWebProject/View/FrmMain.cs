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

            string currentRole = f.CurrentUserRole;
            string userName = "登出" + f.CurrentUserName ;
            if (userName == null)
                userName = "登出使用者";
            toolStripButton10.Text = userName;
            SetPermissions(currentRole);
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
            
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            MessageBox.Show("您已登出");
            toolStripButton10.Text = "使用者您好";
            f.ShowDialog();

            string userName = "登出" + f.CurrentUserName;
            if (userName == null)
                userName = "登出使用者";
            toolStripButton10.Text = userName;
        }
        private void SetPermissions(string roleName)
        {
            // 預設所有按鈕不可用
            FrmMember.Enabled = false; 
            FrmUsedProduct.Enabled = false; 
            FrmNewProduct.Enabled = false; 
            FrmCourse.Enabled = false; 
            FrmSite.Enabled = false; 
            FrmOrder.Enabled = false; 
            FrmReview.Enabled = false; 
            FrmAdminSetting.Enabled  = false; 
            FrmCoachList.Enabled = false; 

            // 根據角色開啟對應按鈕
            switch (roleName)
            {
                case "一般":
                    break;

                case "文案管理員":
                    FrmReview.Enabled = true;
                    break;

                case "會員管理員":
                    FrmMember.Enabled = true; 
                    FrmCoachList.Enabled = true; 
                    break;

                case "產品管理員":
                    FrmUsedProduct.Enabled = true;
                    FrmNewProduct.Enabled = true; 
                    FrmCourse.Enabled = true; 
                    FrmSite.Enabled = true; 
                    break;

                case "訂單管理員":
                    FrmOrder.Enabled = true; 
                    break;

                case "系統管理員":
                case "超級管理員":
                    FrmMember.Enabled = true;
                    FrmUsedProduct.Enabled = true;
                    FrmNewProduct.Enabled = true;
                    FrmCourse.Enabled = true;
                    FrmSite.Enabled = true;
                    FrmOrder.Enabled = true;
                    FrmReview.Enabled = true;
                    FrmAdminSetting.Enabled = true;
                    FrmCoachList.Enabled = true;
                    break;

                default:
                    MessageBox.Show("未知角色，無法設定權限");
                    break;
            }
        }

        private void FrmMain_Enter(object sender, EventArgs e)
        {
            this.FrmMain_Load(sender, e);
        }
    }
}
