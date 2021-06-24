using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BankTypes;
using BankBO;

namespace BankDAL
{
    public class LoginDB : ILoginDB
    {
        public List<Ilogin> retriveuser(string username)
        {
            SqlConnection conn = new SqlConnection();
            string ConnectionString;
            ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
            conn.ConnectionString = ConnectionString;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "retriveuser";
            cmd.Parameters.AddWithValue("@username",username );
            List<Ilogin> user = new List<Ilogin>();
            SqlDataReader reader = cmd.ExecuteReader();
            string password;
            int type;
            DateTime datestamp;
            while (reader.Read())
            {

                username = Convert.ToString(reader["username"]);
                password = Convert.ToString(reader["password"]);
                type = Convert.ToInt32(reader["type"]);
                datestamp = DateTime.Now;
                user.Add(new login(username, password, datestamp, type));
            }
            return user;

        }
    }
}