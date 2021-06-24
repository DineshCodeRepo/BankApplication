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
    public class AccountSearchAndDetials : IAccountSearchAndDetials
    {
        public List<Iaccount> RetiveAccount(long customerid)
        {
            SqlConnection conn = new SqlConnection();
            string ConnectionString;
            ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
            conn.ConnectionString = ConnectionString;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "readaccountcustid";
            cmd.Parameters.AddWithValue("@cusid", customerid);
            SqlDataReader reader = cmd.ExecuteReader();
            
            
            List<Iaccount> accounts= new List<Iaccount>();

            long accountid;
            string type;
            string accstatus;
            string accmessage;
            long balance;

            while (reader.Read())
            {
                customerid = Convert.ToInt64(reader["cusid"]);
                accountid = Convert.ToInt64(reader["accid"]);
                type = reader["acctype"].ToString();
                accstatus = reader["status"].ToString();
                accmessage = reader["message"].ToString();
                balance = Convert.ToInt64(reader["amount"]);

                accounts.Add(new account(customerid, accountid, type, accstatus, accmessage, balance,DateTime.Now.Date));
            }
            return accounts;
        }
        public List<Iaccount> RetiveAccountDetials(long accountid)
        {
            SqlConnection conn = new SqlConnection();
            string ConnectionString;
            ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
            conn.ConnectionString = ConnectionString;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "readaccountid";
            cmd.Parameters.AddWithValue("@accid", accountid);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Iaccount> accounts = new List<Iaccount>();
   
            long customerid;
            string type;
            string accstatus;
            string accmessage;
            long balance;

            while (reader.Read())
            {
                customerid = Convert.ToInt64(reader["cusid"]);
                accountid = Convert.ToInt64(reader["accid"]);
                type = reader["acctype"].ToString();
                accstatus = reader["status"].ToString();
                accmessage = reader["message"].ToString();
                balance = Convert.ToInt64(reader["amount"]);
                accounts.Add(new account(customerid, accountid, type, accstatus, accmessage, balance,DateTime.Now.Date));
            }
            return accounts;

        }
        public List<Iaccount> RetiveAllAccountDetials()
        {
            SqlConnection conn = new SqlConnection();
            string ConnectionString;
            ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
            conn.ConnectionString = ConnectionString;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "viewaccount";
            SqlDataReader reader = cmd.ExecuteReader();
            List<Iaccount> accounts = new List<Iaccount>();
            long accountid;
            long customerid;
            string type;
            string accstatus;
            string accmessage;
            long balance;

            while (reader.Read())
            {
                customerid = Convert.ToInt64(reader["cusid"]);
                accountid = Convert.ToInt64(reader["accid"]);
                type = reader["acctype"].ToString();
                accstatus = reader["status"].ToString();
                accmessage = reader["message"].ToString();
                balance = Convert.ToInt64(reader["amount"]);
                accounts.Add(new account(customerid, accountid, type, accstatus, accmessage, balance,DateTime.Now.Date));
            }
            return accounts;

        }
    }
}