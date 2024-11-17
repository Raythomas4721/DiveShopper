using divingWebProject.Modal;
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
    public partial class FrmUsedProduct : Form
    {
        public FrmUsedProduct()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)  //新增
        {
            FrmUsedProductEditor f = new FrmUsedProductEditor();
            f.ShowDialog();


            if (f.isOk == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow row = dt.NewRow();
                row["productName"] = f.usedProduct.productName;
                row["categoryId"] = f.usedProduct.categoryId;
                row["productPrice"] = f.usedProduct.productPrice;
                row["productConditionId"] = f.usedProduct.productConditionId;
                row["productDescription"] = f.usedProduct.productDescription;
                row["productId"] = f.usedProduct.productId;
                row["sellerId"] = f.usedProduct.sellerId;
                row["createdAt"] = f.usedProduct.createdAt;


                dt.Rows.Add(row);
            }

        }

        SqlDataAdapter _da;
        SqlCommandBuilder _builder;
        private void FrmUsedProduct_Load(object sender, EventArgs e)
        {
            displayProductBySql("SELECT * FROM tUproducts",false); //dataTable
        }

        private void displayProductBySql(string sql,bool iskeyword)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=SSPI;";
            con.Open();

            _da = new SqlDataAdapter(sql, con);
            if (iskeyword)
                _da.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD",
                    "%" + (object)toolStripTextBox1.Text + "%"));
            _builder = new SqlCommandBuilder();
            _builder.DataAdapter = _da;

            DataSet ds = new DataSet();
            _da.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0];

            resetGridStyle();
        }

        private void FrmUsedProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            _da.Update(dataGridView1.DataSource as DataTable);
        }

        int _position = -1;
        private void Revise_Click(object sender, EventArgs e) //修改
        {
            if (_position < 0)
                return;
            DataRow row = (dataGridView1.DataSource as DataTable).Rows[_position];
            FrmUsedProductEditor f = new FrmUsedProductEditor();
            CUsedProduct x = new CUsedProduct();
            
            x.productName = row["productName"].ToString();  // 假設 productName 是 string 類型
            x.categoryId = Convert.ToInt32(row["categoryId"]);  // 假設 categoryId 是 int 類型
            x.productPrice = Convert.ToDecimal(row["productPrice"]);  // 假設 productPrice 是 decimal 類型
            x.productConditionId = Convert.ToInt32(row["productConditionId"]);  // 假設 productConditionId 是 int 類型
            x.productDescription = row["productDescription"].ToString();  // 假設 productDescription 是 string 類型
            x.productId = Convert.ToInt32(row["productId"]);  // 假設 productId 是 int 類型
            x.sellerId = Convert.ToInt32(row["sellerId"]);  // 假設 sellerId 是 int 類型
            x.updatedAt = DateTime.Now.ToString();

            int categoryId;
            if (int.TryParse(row["categoryId"].ToString(), out categoryId))
            {
                x.categoryId = categoryId;
            }
            else
            {
                // 處理轉換失敗的情況
                x.categoryId = 0; // 或者其他預設值
            }
            f.usedProduct = x;
            f.ShowDialog();

            if (f.isOk == DialogResult.OK)
            {
                row["productName"] = f.usedProduct.productName;
                row["categoryId"] = f.usedProduct.categoryId;
                row["productPrice"] = f.usedProduct.productPrice;
                row["productConditionId"] = f.usedProduct.productConditionId;
                row["productDescription"] = f.usedProduct.productDescription;
                row["productId"] = f.usedProduct.productId;
                row["sellerId"] = f.usedProduct.sellerId;
                row["updatedAt"] = f.usedProduct.updatedAt;
            }
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }
        private void Delete_Click(object sender, EventArgs e) //刪除
        {
            if (_position < 0)
                return;
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow row = dt.Rows[_position];
            row.Delete();
            _da.Update(dataGridView1.DataSource as DataTable);
        }

        private void FrmUsedProduct_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }

        private void resetGridStyle()
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].Width = 250;
            dataGridView1.Columns[7].Width = 250;
            dataGridView1.Columns[8].Width = 80;
            dataGridView1.Columns[9].Width = dataGridView1.Width - 1210 - dataGridView1.RowHeadersWidth;

            bool isColorChanged = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                isColorChanged = !isColorChanged;

                r.DefaultCellStyle.Font = new Font("微軟正黑體", 16);
                r.DefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
                if (isColorChanged)
                    r.DefaultCellStyle.BackColor = Color.FromArgb(201,200,227);
            }
        }

        private void Search_Click(object sender, EventArgs e) //查詢
        {
            string sql = "SELECT * FROM tUproducts WHERE ";
            sql += " productName LIKE @K_KEYWORD ";
            sql += " OR productDescription LIKE @K_KEYWORD ";

            displayProductBySql(sql, true);
        }
    }
}
