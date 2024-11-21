using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace divingWebProject.Modal
{
    public class CSiteMangers
    {
        public void create(CSite p)
        {
            string sql = "INSERT INTO tSsiteDetail (";

            sql += "VenueName,";
            sql += "NumberOfPeople,";
            sql += "VenueAddress,";
            sql += "Detail,";
            sql += "State";
            sql += ")VALUES(";
            sql += "'"+p.venueName+"',";
            sql += "'"+p.numberOfPeople+"',";
            sql += "'"+p.venueAddress+"',";
            sql += "'"+p.detail + "',";
            sql += "'"+p.state + "')";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            con.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            con.Close();
            
        }
        public List<CSite> geyBySql(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;

            SqlDataReader reader = cmd.ExecuteReader();
            List<CSite> list = new List<CSite>();
            if (reader.Read())
            {
                CSite x= new CSite();
                x.venueName = reader["venueName"].ToString();
                x.numberOfPeople = (int)reader["numberOfPeople"];
                x.venueAddress = reader["venueAddress"].ToString();
                x.detail = reader["detail"].ToString();
                x.state = reader["state"].ToString();
                list.Add(x);
            }
            
            con.Close();
            return list;
        }
    }
}
