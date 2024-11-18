using divingWebProject.Modal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divingWebProject.View
{
    public class CNProductManger
    {
            public void create(CNProductvariant p)//新增的方法
            {

                string sql = "INSERT INTO tNproductvariants (";
                sql += "性別編號,";
                sql += "顏色編號,";
                sql += "尺寸編號,";
                sql += "進貨量,";
                sql += "產品編號,";
                sql += "厚度編號";
                sql += ")VALUES(";
                sql += "@K_FGENDER,";
                sql += "@K_FCOLOR ,";
                sql += "@K_FSIZE,";
                sql += "@K_STOCK,";
                sql += "@K_FID,";
                sql += "@K_FTHICKNESS)";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("@K_FID", (object)p.fId));
                cmd.Parameters.Add(new SqlParameter("@K_FGENDER", (object)p.fgender));//簡寫
                cmd.Parameters.Add(new SqlParameter("@K_FCOLOR", (object)p.fcolor));
                cmd.Parameters.Add(new SqlParameter("@K_FSIZE", (object)p.fsize));
                cmd.Parameters.Add(new SqlParameter("@K_STOCK", (object)p.fstock));
                cmd.Parameters.Add(new SqlParameter("@K_FTHICKNESS", (object)p.fthickness));
                cmd.ExecuteNonQuery();
                con.Close();
            }

            public void update(CNProductvariant p)    //修改的方法
            {
                string sql = "UPDATE tNproductvariants SET ";

                sql += "顏色編號=@K_FCOLOR ,";
                sql += "性別編號=@K_FGENDER,";
                sql += "尺寸編號=@K_FSIZE,";
                sql += "厚度編號=@K_FTHICKNESS,";
                sql += "進貨量=@K_STOCK,";
                sql += "產品編號=@K_FID";


                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;

                cmd.Parameters.Add(new SqlParameter("@K_FCOLOR", (object)p.fcolor));
                cmd.Parameters.Add(new SqlParameter("@K_FGENDER", (object)p.fgender));
                cmd.Parameters.Add(new SqlParameter("@K_FSIZE", (object)p.fsize));
                cmd.Parameters.Add(new SqlParameter("@K_FTHICKNESS", (object)p.fthickness));
                cmd.Parameters.Add(new SqlParameter("@K_STOCK", (object)p.fstock));
                cmd.Parameters.Add(new SqlParameter("@K_FID", (object)p.fId.ToString()));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }


