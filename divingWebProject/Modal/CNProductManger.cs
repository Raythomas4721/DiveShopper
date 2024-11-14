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
        public void create()//新增商品的方法
        {

            string sql = "INSERT INTO tNproductvariants (";
            //sql += "productName,";
            //sql += "unitPrice,";
            sql += "genderId,";
            sql += "colorId,";
            sql += "sizeId,";
            sql += "thicknessId";
            sql += ")VALUES(";
            sql += "@K_FGENDER,";
            sql += "@K_FCOLOR ,";
            sql += "@K_FSIZE,";
            sql += "@K_FTHICKNESS)";

            sql += "INSERT INTO tNproduct (";
            sql += "productName,";
            sql += "unitPrice,";
            sql += "unitCost,";
            sql += ")VALUES(";
            sql += "@K_FPRODUCTNAME,";
            sql += "@K_FUNITPRICE ,";
            sql += "@K_FCOST)";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Integrated Security=True;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteReader();
            con.Close();
        }

        //public void update()    //修改產品的方法
        //{
        //    string sql = "UPDATE tProduct SET ";
        //    sql += "fname=@K_FNAME,";
        //    sql += "fcolor=@K_FCOLOR ,";
        //    sql += "fgender=@K_FGENDER,";
        //    sql += "fsize=@K_FSIZE,";
        //    sql += "fthickness=@K_FTHICKNESS";
        //    sql += " WHERE fId=@K_FID";


        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True;";
        //    con.Open();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = sql;
        //    cmd.Parameters.Add(new SqlParameter("@K_FNAME", (object)p.fName));
        //    cmd.Parameters.Add(new SqlParameter("@K_FCOLOR", (object)p.fPhone));
        //    cmd.Parameters.Add(new SqlParameter("@K_FGENDER", (object)p.fEmail));
        //    cmd.Parameters.Add(new SqlParameter("@K_FSIZE", (object)p.fAddress));
        //    cmd.Parameters.Add(new SqlParameter("@K_FTHICKNESS", (object)p.fPassword));
        //    cmd.Parameters.Add(new SqlParameter("@K_FID", (object)p.fId.ToString()));
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}
    }
    }

