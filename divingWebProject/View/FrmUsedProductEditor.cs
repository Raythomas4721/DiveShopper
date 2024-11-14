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
    public partial class FrmUsedProductEditor : Form
    {
        private CUsedProduct _usedProduct;
        public CUsedProduct usedProduct
        {
            get
            {
                if (usedProduct == null)
                    _usedProduct = new CUsedProduct();
                _usedProduct.productName = fproductName.Text; //商品名稱
                _usedProduct.categoryId = Convert.ToInt32(fcategoryId.SelectedValue); //商品分類
                _usedProduct.productPrice = Convert.ToDecimal(fproductPrice.Text); //商品價錢
                _usedProduct.productConditionId = Convert.ToInt32(fproductConditionId.Text); //商品狀況
                _usedProduct.productDescription = fproductDescription.Text; //商品描述
                _usedProduct.productId = Convert.ToInt32(fproductId.Text); //商品ID
                _usedProduct.sellerId = Convert.ToInt32(fsellerId.Text); //賣家ID

                DateTime createdAt; //商品上架時間
                if (DateTime.TryParse(fcreatedAt.Text, out createdAt))
                {
                    _usedProduct.createdAt = createdAt;
                }
                else
                {
                    MessageBox.Show("請輸入有效的日期格式（例如：yyyy-MM-dd）", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                return _usedProduct;

            }
            set
            {
                _usedProduct = value;
                fproductName.Text = _usedProduct.productName; // 商品名稱
                fcategoryId.SelectedValue = _usedProduct.categoryId.ToString(); // 商品分類
                fproductPrice.Text = _usedProduct.productPrice.ToString(); // 商品價錢
                fproductConditionId.Text = _usedProduct.productConditionId.ToString(); // 商品狀況
                fproductDescription.Text = _usedProduct.productDescription; // 商品描述
                fproductId.Text = _usedProduct.productId.ToString(); // 商品ID
                fsellerId.Text = _usedProduct.sellerId.ToString(); // 賣家ID

                if (_usedProduct.image != null)
                {
                    try
                    {
                        Stream streamImage = new MemoryStream(_usedProduct.image);
                        pictureBox1.Image = Bitmap.FromStream(streamImage);
                    }
                    catch { }
                }
            }
        }
        
        public FrmUsedProductEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public DialogResult isOk { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            string message = "";
            if (string.IsNullOrEmpty(fproductName.Text))
                message += "\r\n商品名稱不可空白";
            if (string.IsNullOrEmpty(fproductDescription.Text))
                message += "\r\n商品描述不可空白";
            if (string.IsNullOrEmpty(fproductPrice.Text))
                message += "\r\n價錢不可空白";
            else
            {
                if (!isNumber(fproductPrice.Text))
                    message += "\r\n價錢必須是數字";
            }
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
                return;
            }

            this.isOk = DialogResult.OK;

            Close();
        }
        private bool isNumber(string p)
        {
            try
            {
                double d = Convert.ToDouble(p);
                return true;
            }
            catch
            {
                return false;
            }
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
