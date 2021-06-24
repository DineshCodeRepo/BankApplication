using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankTypes;
using BankDAL;
using BankBO;

namespace BankBLL
{
    public class CustomerBLL:ICustomerBLL
    {
        public int createCustomer(long customerssnid, long customerid, string customername, int age, string address, string city, string state, string cusstatus, string cusmessage, DateTime updatedate)
        {
            ICustomer customer = new Customer(customerssnid, customerid, customername, age, address,  city,  state,  cusstatus,  cusmessage,  updatedate);
            IOperations operation = new Operations();
            int rowsaff = operation.addCustomer(customer);
            return rowsaff;
        }

        public int updateCustomer(long customerssnid, long customerid, string customername, int age, string address, string city, string state, string cusstatus, string cusmessage, DateTime updatedate)
        {
            ICustomer customer = new Customer(customerssnid, customerid, customername, age, address, city, state, cusstatus, cusmessage, updatedate);
            IOperations operation = new Operations();
            int rowsaff = operation.updateCustomer(customer);
            return rowsaff;
        }

        public List<ICustomer> retriveCusDetails(long customerid, long customerssnid)
        {
           // ICustomer customer = new Customer(customerssnid, customerid);
            IOperations operation = new Operations();
            List<ICustomer> cusList = operation.retriveCusDetails(customerid, customerssnid);
            return cusList;
        }
        public int deleteCustomer(long customerssnid, long customerid, string customername, int age, string address, string city, string state, string cusstatus, string cusmessage, DateTime updatedate)
        {
            ICustomer customer = new Customer(0, customerid, customername, age, address, city, state, cusstatus, cusmessage, updatedate);
            IOperations operation = new Operations();
            int rowsaff = operation.deleteCustomer(customer);
            return rowsaff;
        }
        public List<ICustomer> viewall()
        { List<ICustomer> cuslist = new List<ICustomer>();
            IOperations operation = new Operations();
          
            cuslist = operation.viewall();
            return cuslist;
        }
    }
}
