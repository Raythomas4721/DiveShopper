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
        //public void create(CProduct p)//新增商品的方法
        //{

        //    string sql = "INSERT INTO tProduct (";
        //    sql += "fname,";
        //    sql += "fcolor,";
        //    sql += "fgender,";
        //    sql += "fsize,";
        //    sql += "fthickness";
        //    sql += ")VALUES(";
        //    sql += "@K_FNAME,";
        //    sql += "@K_FCOLOR ,";
        //    sql += "@K_FGENDER,";
        //    sql += "@K_FSIZE,";
        //    sql += "@K_FTHICKNESS)";

        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = @"";
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = sql;
        //    cmd.ExecuteReader();
        //    con.Close();
        //}

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

