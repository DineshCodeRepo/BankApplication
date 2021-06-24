using System;
using System.Collections.Generic;
using BankTypes;

namespace BankTypes
{
    public interface IAccountBLL
    {
        int createAccount(long customerid, long accountid, string type, string accstatus, string accmessage, long balance, DateTime updatedate);
        int deleteAccount(long customerid, long accountid, string type, string accstatus, string accmessage, long balance, DateTime updatedate);
        List<Iaccount> retriveaccount(long accountid);
        List<Iaccount> retriveaccounts(long customerid);
        List<Iaccount> retrivealldetials();
        List<Iaccount> viewAccountID(long accountid=0, long cusid=0);
    }
}