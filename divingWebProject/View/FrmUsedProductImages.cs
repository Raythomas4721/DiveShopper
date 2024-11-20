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

namespace divingWebProject.View
{
    public partial class FrmUsedProductImages : Form
    {
        public FrmUsedProductImages()
        {
            InitializeComponent();
        }
        //int _position = -1;
        //private CUsedProduct _usedProduct;
        //public CUsedProduct usedProduct
        //{
            //get
            //{
            //    if (_usedProduct == null)
            //        _usedProduct = new CUsedProduct();

            //    if (_usedProduct.image != null)
            //    {
            //        try
            //        {
            //            Stream streamImage = new MemoryStream(_usedProduct.image);
            //            pictureBox1.Image = Bitmap.FromStream(streamImage);
            //        }
            //        catch { }
            //    }

            //    return _usedProduct;

            //}
            //set
            //{
            //    _usedProduct = value;

            //    if (_usedProduct.image != null)
            //    {
            //        try
            //        {
            //            Stream streamImage = new MemoryStream(_usedProduct.image);
            //            pictureBox1.Image = Bitmap.FromStream(streamImage);
            //        }
            //        catch { }
            //    }
            //}
        //}
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            //if (_position < 0)
            //    return;
            //DataTable dt = dataGridView1.DataSource as DataTable;
            //DataRow row = dt.Rows[_position];
            //openFileDialog1.Filter = "照片|*.png|照片|*.jpg";
            //if (openFileDialog1.ShowDialog() != DialogResult.OK)
            //    return;
            //pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);

            //byte[] imageBytes;
            //using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
            //{
            //    using (BinaryReader reader = new BinaryReader(fs))
            //    {
            //        imageBytes = reader.ReadBytes((int)fs.Length);  // 讀取整個檔案為位元組陣列
            //    }
            //}

            //// 建立 SQL 連線並插入圖片
            //using (SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=diveShopper;Integrated Security=SSPI;"))
            //{
            //    // SQL 插入語句
            //    string query = "INSERT INTO tUproductImages (productId, image) " +
            //                   "VALUES (@productId, @image)";

            //    SqlCommand command = new SqlCommand(query, connection);

            //    // 假設 ProductID 是您想關聯的產品 ID，這裡假設為 1
            //    command.Parameters.AddWithValue("@productId", this.usedProduct.productId);  // 使用 yourProductID，這裡假設為 1
            //    command.Parameters.AddWithValue("@image", imageBytes);  // 插入圖片的二進位資料

            //    try
            //    {
            //        connection.Open();  // 開啟資料庫連線
            //        command.ExecuteNonQuery();  // 執行插入操作
            //        MessageBox.Show("圖片已成功儲存至資料庫！");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("儲存圖片到資料庫時發生錯誤: " + ex.Message);
            //    }
            //}
        }
    }
}
