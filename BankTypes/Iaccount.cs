using System;

namespace BankTypes
{
    public interface Iaccount
    {
        string Accmessage { get; set; }
        long Accountid { get; set; }
        string Accstatus { get; set; }
        long Balance { get; set; }
        long Customerid { get; set; }
        string Type { get; set; }
        DateTime Updatedate { get; set; }
    }
}