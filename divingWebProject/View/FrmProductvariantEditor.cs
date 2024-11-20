using divingWebProject.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace divingWebProject.View
{
    public partial class FrmProductvariantEditor : Form
    {
        public DialogResult isOK { get; set; }
        private CNProductvariant _newproductvariant;
        public FrmProductvariantEditor()
        {
            InitializeComponent();
        }
        public CNProductvariant newproductvariant
        {
            get
            {
                if (_newproductvariant == null)
                    _newproductvariant = new CNProductvariant();
              
                    _newproductvariant.fId = Convert.ToInt32(fbId.filedValue);
                _newproductvariant.fcolor = fbColor.SelectedIndex;
                _newproductvariant.fsize = fbSize.SelectedIndex;
                _newproductvariant.fgender = fbGender.SelectedIndex;
                _newproductvariant.fthickness = fbThickness.SelectedIndex;
                _newproductvariant.fstock = Convert.ToInt32(fbstock.filedValue);
                return _newproductvariant;
            }
            set
            {
                _newproductvariant = value;
                fbId.filedValue = _newproductvariant.fId.ToString();
                fbSize.SelectedIndex = _newproductvariant.fsize;
                fbColor.SelectedIndex = _newproductvariant.fcolor;
                fbGender.SelectedIndex = _newproductvariant.fgender;
                fbThickness.SelectedIndex = _newproductvariant.fthickness;
                fbstock.filedValue = _newproductvariant.fstock.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmNew_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void uiButton1_Click_1(object sender, EventArgs e)
        {
            string message = "";//用一個空字串儲存錯誤訊息
            //如果沒填
            if (string.IsNullOrEmpty(fbId.filedValue))
                message += "\r\n產品編號不可空白";

            if (string.IsNullOrEmpty(fbstock.filedValue))
                message += "\r\n數量不可空白";

            else //如果有填
            {
                if (!isNumber(fbId.filedValue))//如果不是number
                 message += "\r\n產品編號必須是數字";
                if (!isNumber(fbstock.filedValue))//如果不是number
                    message += "\r\n產品數量必須是數字"; 
            }

            if (!string.IsNullOrEmpty(message))//如果message不是空的，IsNullOrEmpty(message)如果是空值是true，如果不是空值是false
            {
                MessageBox.Show(message);//印出錯誤訊息
                return;
            }

            if (fbSize.SelectedIndex < 0 || fbColor.SelectedIndex < 0 || fbGender.SelectedIndex < 0 || fbThickness.SelectedIndex < 0)
            {
                MessageBox.Show("請確保所有選項都已選擇！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // 停止後續操作
            }
            //if (fbSize.SelectedIndex < 0)
            //     MessageBox.Show("請選擇尺寸，沒有請選無選擇");

            //if (fbColor.SelectedIndex < 0)
            //    MessageBox.Show("請選擇顏色，沒有請選無選擇");
            //if (fbGender.SelectedIndex < 0)
            //    MessageBox.Show("請選擇防寒衣性別款式，沒有請選無選擇");
            //if (fbThickness.SelectedIndex < 0)
            //    MessageBox.Show("請選擇防寒衣厚度，沒有請選無選擇");


            this.isOK = DialogResult.OK;
            Close();
        }
        private bool isNumber(string p)//用來檢查給定的字串 p 是否能夠成功轉換為數字(p為fbPrice.filedValue)
        {
            try// 嘗試執行可能會引發異常的程式碼
            {
                double d = Convert.ToDouble(p);
                return true;
            }
            catch // 異常處理代碼，處理錯誤
            { return false; }
        }

        private void fbColor_Validated(object sender, EventArgs e)
        {

        }
    }
}

