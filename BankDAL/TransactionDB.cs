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
    public class TransactionDB : ITransactionDB
    {
        public List<Itransaction> retrivetransaction(long accountid,int nooftrans)
        {
            SqlConnection conn = new SqlConnection();
            string ConnectionString;
            ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
            conn.ConnectionString = ConnectionString;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "accstatementbytrans";
            cmd.Parameters.AddWithValue("@accountid", accountid);
            cmd.Parameters.AddWithValue("@nooftrans", nooftrans);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Itransaction> transacs = new List<Itransaction>(); 
            long transactionid;
            long toaccountid;
            DateTime date;
            string description;
            long amount;

            while (reader.Read())
            {
                
                accountid = Convert.ToInt64(reader["accountid"]);
                toaccountid = Convert.ToInt64(reader["toaccountid"]);
                transactionid = Convert.ToInt64(reader["transactionid"]);
                description = reader["description"].ToString();
                amount = Convert.ToInt64(reader["amount"]);
                date = Convert.ToDateTime(reader["date"]).Date;
                transacs.Add(new transaction(accountid, date, description, amount, toaccountid, transactionid));
            }
            return transacs;
        }
        public List<Itransaction> retrivetransactionbydate(long accountid, DateTime startdate,DateTime enddate)
        {
            SqlConnection conn = new SqlConnection();
            string ConnectionString;
            ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
            conn.ConnectionString = ConnectionString;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "accstatementbydate";
            cmd.Parameters.AddWithValue("@accountid", accountid);
            cmd.Parameters.AddWithValue("@startdate", startdate.Date);
            cmd.Parameters.AddWithValue("@enddate", enddate.Date);
           
            SqlDataReader reader = cmd.ExecuteReader();
            List<Itransaction> transacs = new List<Itransaction>();
            long transactionid;
            long toaccountid;
            DateTime date;
            string description;
            long amount;

            while (reader.Read())
            {

                accountid = Convert.ToInt64(reader["accountid"]);
                toaccountid = Convert.ToInt64(reader["toaccountid"]);
                transactionid = Convert.ToInt64(reader["transactionid"]);
                description = reader["description"].ToString();
                amount = Convert.ToInt64(reader["amount"]);
                date = Convert.ToDateTime((reader["date"]));
                date = date.Date;
                transacs.Add(new transaction(accountid, date, description, amount, toaccountid, transactionid));
            }
            return transacs;
        }
        public long depositwithdraw(Itransaction trans)
        {
            SqlConnection conn = new SqlConnection();
            string ConnectionString;
            ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
            conn.ConnectionString = ConnectionString;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updatebalance";
            cmd.Parameters.AddWithValue("@accountid", trans.Accountid);
            cmd.Parameters.AddWithValue("@description", trans.Description);
            cmd.Parameters.AddWithValue("@amount", trans.Amount);
            cmd.Parameters.AddWithValue("@toaccountid", trans.Toaccountid);
            int flag = cmd.ExecuteNonQuery();


            if (flag != 0)
            {
                cmd.CommandText = "inserttransac";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@accountid", trans.Accountid);
                cmd.Parameters.AddWithValue("@date", trans.Date);
                cmd.Parameters.AddWithValue("@description", trans.Description);
                cmd.Parameters.AddWithValue("@amount", trans.Amount);
                cmd.Parameters.AddWithValue("@toaccountid", trans.Toaccountid);
                cmd.Parameters.Add("@transactionid", SqlDbType.BigInt).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                
                trans.Transactionid = Convert.ToInt64(cmd.Parameters["@transactionid"].Value.ToString());
                return trans.Transactionid;
            }
            conn.Close();
            return trans.Transactionid;

        }
        
    }
}