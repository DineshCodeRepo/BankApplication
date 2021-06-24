using System;
using System.Collections.Generic;

namespace BankTypes
{
    public interface ICustomerBLL
    {
        int createCustomer(long customerssnid, long customerid, string customername, int age, string address, string city, string state, string cusstatus, string cusmessage, DateTime updatedate);
        int updateCustomer(long customerssnid, long customerid, string customername, int age, string address, string city, string state, string cusstatus, string cusmessage, DateTime updatedate);
        List<ICustomer> retriveCusDetails(long customerid, long customerssnid);
        int deleteCustomer(long customerssnid, long customerid, string customername, int age, string address, string city, string state, string cusstatus, string cusmessage, DateTime updatedate);
        List<ICustomer> viewall();
    }
}