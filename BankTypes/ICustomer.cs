using System;

namespace BankTypes
{
    public interface ICustomer
    {
        string Address { get; set; }
        int Age { get; set; }
        string City { get; set; }
        string Cusmessage { get; set; }
        string Cusstatus { get; set; }
        long Customerid { get; set; }
        string Customername { get; set; }
        long Customerssnid { get; set; }
        string State { get; set; }
        DateTime Updatedate { get; set; }
    }
}