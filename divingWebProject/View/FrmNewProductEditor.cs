using AntdUI.Theme;
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
                _newproduct.fId = Convert.ToInt32(fbId.filedValue);
                _newproduct.fname = fbName.filedValue;
                _newproduct.fgender = fbGender.filedValue;
                _newproduct.fthickness = fbThickness.filedValue;
                //_newproduct.fqty = Convert.ToDecimal(fbqty.filedValue);
                //_newproduct.fprice = Convert.ToDecimal(fbPrice.filedValue);
                _newproduct.fsize = fbSize.filedValue;
                _newproduct.fcolor = fbColor.filedValue;

                return _newproduct;
            }
            set
            {
                _newproduct = value;
                fbId.filedValue = _newproduct.fId.ToString();
                fbName.filedValue = _newproduct.fname;
                fbGender.filedValue = _newproduct.fgender;
                fbThickness.filedValue = _newproduct.fthickness;
                fbQty.filedValue= _newproduct.fqty.ToString();
                fbPrice.filedValue= _newproduct.fprice.ToString();
                fbSize.filedValue = _newproduct.fsize;
                fbColor.filedValue = _newproduct.fcolor;

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
            openFileDialog1.Filter = "房間照片|*.png|房間照片|*.jpg";
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
        //    string message = "";

        //    if (string.IsNullOrEmpty(fbName.filedValue))
        //        message += "\r\n房型不可空白";

        //    if (string.IsNullOrEmpty(fbPrice.filedValue))
        //        message += "\r\n房價不可空白";

        //    else //如果有填
        //    {
        //        if (!isNumber(fbPrice.filedValue))//如果不是number
        //            message += "\r\n房價必須是數字";
        //    }

        //    if (!string.IsNullOrEmpty(message))//如果message不是空的，IsNullOrEmpty(message)如果是空值是true，如果不是空值是false
        //    {
        //        MessageBox.Show(message);//印出錯誤訊息
        //        return;
        //    }
        //}
        //    private bool isNumber(string p)//用來檢查給定的字串 p 是否能夠成功轉換為數字(p為fbPrice.filedValue)
        //    {
        //        try// 嘗試執行可能會引發異常的程式碼
        //        {
        //            double d = Convert.ToDouble(p);
        //            return true;
        //        }
        //        catch // 異常處理代碼，處理錯誤
        //        { return false; }
        //    }

            this.isOK = DialogResult.OK;
            Close();
        }

       
    }
    }

