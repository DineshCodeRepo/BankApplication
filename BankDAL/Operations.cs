using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BankTypes;
using BankBO;



namespace BankDAL
{
    public class Operations : IOperations
    {
        public int addAccount(Iaccount account)
        {
            try
            {
                int rowsaff;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Addaccount";

                cmd.Parameters.AddWithValue("@cusid", account.Customerid);
                cmd.Parameters.AddWithValue("@acctype", account.Type);
                cmd.Parameters.AddWithValue("@amount", account.Balance);
                cmd.Parameters.AddWithValue("@status", account.Accstatus);
                cmd.Parameters.AddWithValue("@message", account.Accmessage);
                cmd.Parameters.AddWithValue("@lastupdated", account.Updatedate);


                rowsaff = cmd.ExecuteNonQuery();

                con.Close();

                return rowsaff;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int deleteAccount(Iaccount account)
        {
            try
            {
                int rowsaff;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_deleteAccount";

                cmd.Parameters.AddWithValue("@accid", account.Accountid);
                cmd.Parameters.AddWithValue("@acctype", account.Type);
                cmd.Parameters.AddWithValue("@status", account.Accstatus);
                cmd.Parameters.AddWithValue("@message", account.Accmessage);
                cmd.Parameters.AddWithValue("@lastupdated", account.Updatedate);


                rowsaff = cmd.ExecuteNonQuery();

                con.Close();

                return rowsaff;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public List<Iaccount> ViewAccountID(long accountid = 0, long cusid = 0)
        {

            List<Iaccount> acclist = new List<Iaccount>();

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ViewAll";



                cmd.Parameters.AddWithValue("@accid", accountid);
                cmd.Parameters.AddWithValue("@cusid", cusid);

                SqlDataReader reader = cmd.ExecuteReader();



                long accid;
                long customerid;
                long amount;
                string acctype;
                string status;
                string message;
                DateTime lastupdate;




                while (reader.Read())
                {
                    customerid = long.Parse(reader["cusid"].ToString());
                    acctype = (reader["acctype"].ToString());
                    accid = long.Parse(reader["accid"].ToString());
                    amount = long.Parse(reader["amount"].ToString());
                    status = (reader["status"].ToString());
                    message = (reader["message"].ToString());
                    lastupdate = DateTime.Parse(reader["lastupdate"].ToString());


                    acclist.Add(new account(customerid, accid, acctype, status, message, amount, lastupdate));
                }

                con.Close();

                return acclist;
            }
            catch (Exception)
            {
                return acclist;
            }

        }


        //---------------------------------------------------------------------------------------------------------------------

        public int addCustomer(ICustomer customer)
        {
            try
            {
                int rowsaff;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_addcustomer";

                cmd.Parameters.AddWithValue("@cusSSNid", customer.Customerssnid);
                cmd.Parameters.AddWithValue("@cusname", customer.Customername);
                cmd.Parameters.AddWithValue("@age", customer.Age);
                cmd.Parameters.AddWithValue("@address", customer.Address);
                cmd.Parameters.AddWithValue("@state", customer.State);
                cmd.Parameters.AddWithValue("@city", customer.City);
                cmd.Parameters.AddWithValue("@status", customer.Cusstatus);
                cmd.Parameters.AddWithValue("@message", customer.Cusmessage);
                cmd.Parameters.AddWithValue("@lastupdated", customer.Updatedate);



                rowsaff = cmd.ExecuteNonQuery();

                con.Close();

                return rowsaff;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public List<ICustomer> retriveCusDetails(long cusid, long customerssnid)
        {
            List<ICustomer> cuslist = new List<ICustomer>();

            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_retrivedata";

                cmd.Parameters.AddWithValue("@cusSSNid", customerssnid);
                cmd.Parameters.AddWithValue("@cusid", cusid);

                cmd.ExecuteNonQuery();


                SqlDataReader reader = cmd.ExecuteReader();

                long cusSSNid;
                long customerid;
                string cusname;
                string address;
                int age;



                while (reader.Read())
                {
                    cusSSNid = long.Parse(reader["cusSSNid"].ToString());
                    customerid = long.Parse(reader["cusid"].ToString());
                    cusname = reader["cusname"].ToString();
                    address = reader["address"].ToString();
                    age = int.Parse(reader["age"].ToString());

                    cuslist.Add(new Customer(cusSSNid, customerid, cusname, age, address));
                }
                con.Close();

                return cuslist;
            }
            catch (Exception)
            {
                return cuslist;
            }
        }

        public int updateCustomer(ICustomer customer)
        {
            try
            {
                int rowsaff;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_updatecustomer";
                cmd.Parameters.AddWithValue("@cusSSNid", customer.Customerssnid);
                cmd.Parameters.AddWithValue("@cusid", customer.Customerid);

                cmd.Parameters.AddWithValue("@cusname", customer.Customername);
                cmd.Parameters.AddWithValue("@age", customer.Age);
                cmd.Parameters.AddWithValue("@address", customer.Address);
                cmd.Parameters.AddWithValue("@status", customer.Cusstatus);
                cmd.Parameters.AddWithValue("@message", customer.Cusmessage);
                cmd.Parameters.AddWithValue("@lastupdated", customer.Updatedate);

                rowsaff = cmd.ExecuteNonQuery();
                con.Close();

                return rowsaff;

            }
            catch (Exception)
            {
                return 0;
            }
        }


        public int deleteCustomer(ICustomer customer)
        {
            try
            {
                int rowsaff;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_deletecustomer";

                cmd.Parameters.AddWithValue("@cusSSNid", customer.Customerssnid);
                cmd.Parameters.AddWithValue("@cusid", customer.Customerid);
                cmd.Parameters.AddWithValue("@cusname", customer.Customername);
                cmd.Parameters.AddWithValue("@age", customer.Age);
                cmd.Parameters.AddWithValue("@address", customer.Address);
                cmd.Parameters.AddWithValue("@status", customer.Cusstatus);
                cmd.Parameters.AddWithValue("@message", customer.Cusmessage);
                cmd.Parameters.AddWithValue("@lastupdated", customer.Updatedate);

                rowsaff = cmd.ExecuteNonQuery();
                con.Close();

                return rowsaff;

            }
            catch (Exception)
            {
                return 0;
            }
        }
        public List<ICustomer> viewall()
        {
            List<ICustomer> cuslist = new List<ICustomer>();
            try
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ProductBacklog;Integrated Security=True";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_view";
                SqlDataReader reader = cmd.ExecuteReader();

                long cusSSNid;
                long customerid;
                string cusname;
                string address;
                int age;
                string state;
                string city;
                string status;
                string message;
                DateTime lastupdate;




                while (reader.Read())
                {
                    cusSSNid = long.Parse(reader["cusSSNid"].ToString());
                    customerid = long.Parse(reader["cusid"].ToString());
                    cusname = reader["cusname"].ToString();
                    address = reader["address"].ToString();
                    age = int.Parse(reader["age"].ToString());
                    state = reader["state"].ToString();
                    city = reader["city"].ToString();
                    status = reader["status"].ToString();
                    message = reader["message"].ToString();
                    lastupdate = DateTime.Parse(reader["lastupdated"].ToString());


                    cuslist.Add(new Customer(cusSSNid, customerid, cusname, age, address, city, state, status, message, lastupdate));
                }
                con.Close();

                return cuslist;
            }
            catch (Exception)
            {
                return cuslist;
            }

        }

    }  }