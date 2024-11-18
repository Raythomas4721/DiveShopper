using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divingWebProject.Modal
{
    public class CMmemberManager
    {
        public void createMember(CMmember p)
        {
            string sql = "insert into tMmemberList ( ";
            sql += "memberName, ";
            sql += "memberGender, ";
            sql += "memberPhone, ";
            sql += "memberEmail, ";
            sql += "memberAddress, ";
            sql += "memberPassword, ";
            sql += "memberPhoto, ";
            sql += "urgentContact, ";
            sql += "urgentPhone, ";
            sql += "recentLogin )";
            sql += " values ( ";
            sql += "'" + p.memberName + "',";
            sql += "'" + p.memberGender + "',";
            sql += "'" + p.memberPhone + "',";
            sql += "'" + p.memberEmail + "',";
            sql += "'" + p.memberAddress + "',";
            sql += "'" + p.memberPassword + "',";
            sql += "'" + p.memberPhoto + "',";
            sql += "'" + p.urgentContact + "',";
            sql += "'" + p.urgentPhone + "',";
            sql += "'" + p.recentLogin.ToString("yyyy/MM/dd") + "')";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void updateMember(CMmember p)
        {
            string sql = "update tMmemberList set ";
            sql += "memberName = '" + p.memberName + "',";
            sql += "memberGender = '" + p.memberGender + "',";
            sql += "memberPhone = '" + p.memberPhone + "',";
            sql += "memberEmail = '" + p.memberEmail + "',";
            sql += "memberAddress = '" + p.memberAddress + "',";
            sql += "memberPassword = '" + p.memberPassword  + "',";
            sql += "memberPhoto = '" + p.memberPhoto  + "',";
            sql += "urgentContact = '" + p.urgentContact + "',";
            sql += "urgentPhone = '" + p.urgentPhone + "'";
            sql += " where memberId = " + p.memberId.ToString();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=diveShopper;Integrated Security=True;";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
