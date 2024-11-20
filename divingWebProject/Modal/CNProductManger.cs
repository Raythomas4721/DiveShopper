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
                sql += "genderId,";
                sql += "colorId,";
                sql += "sizeId,";
                sql += "stock,";
                sql += "productId,";
                sql += "thicknessId";
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

            public void update(CNProductvariant p, int id)    //修改的方法
            {
                string sql = "UPDATE tNproductvariants SET ";
            sql += "productId=@K_FproductId ,";
            sql += "colorId=@K_FCOLOR ,";
                sql += "genderId=@K_FGENDER,";
                sql += "sizeId=@K_FSIZE,";
                sql += "thicknessId=@K_FTHICKNESS,";
                sql += "stock=@K_STOCK ";
                sql += "WHERE productvariantsId=@K_FID";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("@K_FproductId", (object)p.fId));
               cmd.Parameters.Add(new SqlParameter("@K_FCOLOR", (object)p.fcolor));
                cmd.Parameters.Add(new SqlParameter("@K_FGENDER", (object)p.fgender));
                cmd.Parameters.Add(new SqlParameter("@K_FSIZE", (object)p.fsize));
                cmd.Parameters.Add(new SqlParameter("@K_FTHICKNESS", (object)p.fthickness));
                cmd.Parameters.Add(new SqlParameter("@K_STOCK", (object)p.fstock));
                cmd.Parameters.Add(new SqlParameter("@K_FID", (object)id));
               cmd.ExecuteNonQuery();
               con.Close();
            }
        }
    }


