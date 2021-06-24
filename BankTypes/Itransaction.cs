using System;

namespace BankTypes
{
    public interface Itransaction
    {
        long Accountid { get; set; }
        long Amount { get; set; }
        DateTime Date { get; set; }
        string Description { get; set; }
        long Toaccountid { get; set; }
        long Transactionid { get; set; }
    }
}