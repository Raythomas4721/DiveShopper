using divingWebProject.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                if (_usedProduct == null)
                    _usedProduct = new CUsedProduct();
                _usedProduct.productName = fproductName.Text; //商品名稱
                _usedProduct.categoryId = Convert.ToInt32(fcategoryId.SelectedValue); //商品分類**
                _usedProduct.productPrice = Convert.ToDecimal(fproductPrice.Text); //商品價錢

                _usedProduct.productConditionId = Convert.ToInt32(fproductConditionId.SelectedValue); // 商品狀況**

                _usedProduct.productDescription = fproductDescription.Text; //商品描述
                _usedProduct.productId = Convert.ToInt32(fproductId.Text); //商品ID
                _usedProduct.sellerId = Convert.ToInt32(fsellerId.Text); //賣家ID
                _usedProduct.createdAt = DateTime.Now.ToString(); //上架時間
                _usedProduct.productStatus = fproductStatus.Checked; //上架
                if (_usedProduct.image != null)
                {
                    try
                    {
                        Stream streamImage = new MemoryStream(_usedProduct.image);
                        pictureBox1.Image = Bitmap.FromStream(streamImage);
                    }
                    catch { }
                }

                return _usedProduct;

            }
            set
            {
                _usedProduct = value;
                fproductName.Text = _usedProduct.productName; // 商品名稱
                fcategoryId.SelectedValue = _usedProduct.categoryId.ToString(); // 商品分類**
                fproductPrice.Text = _usedProduct.productPrice.ToString(); // 商品價錢
                fproductConditionId.Text = _usedProduct.productConditionId.ToString(); // 商品狀況**
                fproductDescription.Text = _usedProduct.productDescription; // 商品描述
                fproductId.Text = _usedProduct.productId.ToString(); // 商品ID
                fsellerId.Text = _usedProduct.sellerId.ToString(); // 賣家ID
                fproductStatus.Checked = _usedProduct.productStatus; //上架

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
            openFileDialog1.Filter = "照片|*.png|照片|*.jpg";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);

            byte[] imageBytes;
            using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    imageBytes = reader.ReadBytes((int)fs.Length);  // 讀取整個檔案為位元組陣列
                }
            }

            // 建立 SQL 連線並插入圖片
            using (SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=diveShopper;Integrated Security=SSPI;"))
            {
                // SQL 插入語句
                string query = "INSERT INTO tUproductImages (productId, image) " +
                               "VALUES (@productId, @image)";

                SqlCommand command = new SqlCommand(query, connection);

                // 假設 ProductID 是您想關聯的產品 ID，這裡假設為 1
                command.Parameters.AddWithValue("@productId", this.usedProduct.productId);  // 使用 yourProductID，這裡假設為 1
                command.Parameters.AddWithValue("@image", imageBytes);  // 插入圖片的二進位資料
                
                try
                {
                    connection.Open();  // 開啟資料庫連線
                    command.ExecuteNonQuery();  // 執行插入操作
                    MessageBox.Show("圖片已成功儲存至資料庫！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("儲存圖片到資料庫時發生錯誤: " + ex.Message);
                }
            }
        }

        private void FrmUsedProductEditor_Load(object sender, EventArgs e)
        {
            DataTable dtcategory = comboboxcategoryId(); //商品分類combobox
            fcategoryId.DataSource = dtcategory;
            fcategoryId.DisplayMember = "categoryName";
            fcategoryId.ValueMember = "categoryId";

            DataTable dtCondition = comboboxproductConditionId(); //狀況combobox
            fproductConditionId.DataSource = dtCondition;
            fproductConditionId.DisplayMember = "condition";  // 顯示欄位
            fproductConditionId.ValueMember = "productConditionId";

            if (_usedProduct != null) 
            {
                fcategoryId.SelectedValue = _usedProduct.categoryId;
                fproductConditionId.SelectedValue = _usedProduct.productConditionId;
            }
            
        }

        public DataTable comboboxcategoryId() //商品分類combobox
        {
            DataTable dtcategory = new DataTable();

            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=diveShopper;Integrated Security=SSPI;")) 
            {
                string sql = "SELECT * FROM tUcategories";
                using (SqlCommand cmd = new SqlCommand(sql,con)) 
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    con.Open();
                    da.Fill(dtcategory);
                    con.Close();
                }
            }
            return dtcategory;
        }
        public DataTable comboboxproductConditionId() //狀況combobox
        {
            DataTable dtCondition = new DataTable();

            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=diveShopper;Integrated Security=SSPI;"))
            {
                string sql = "SELECT * FROM tUproductCondition";  // 查詢商品狀況資料
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    con.Open();
                    da.Fill(dtCondition);
                    con.Close();
                }
            }
            return dtCondition;
        }
    }
}
