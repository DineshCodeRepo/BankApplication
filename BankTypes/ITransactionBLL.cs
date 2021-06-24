using System;
using System.Collections.Generic;
using BankTypes;

namespace BankTypes
{
    public interface ITransactionBLL
    {
        List<Itransaction> retrivetrans(long accountid, int nooftrans);
        List<Itransaction> retrivetransactionbydate(long accountid, DateTime startdate, DateTime enddate);
        long withdrawdeposit(long Accountid, DateTime Date, string Description, long Amount, long Toaccountid);
    }
}