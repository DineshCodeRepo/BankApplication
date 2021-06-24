using System;
using System.Collections.Generic;

namespace BankTypes
{
    public interface ITransactionDB
    {
        long depositwithdraw(Itransaction trans);
        List<Itransaction> retrivetransaction(long accountid, int nooftrans);
        List<Itransaction> retrivetransactionbydate(long accountid, DateTime startdate, DateTime enddate);
    }
}