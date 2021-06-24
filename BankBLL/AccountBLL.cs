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
    public class AccountBLL : IAccountBLL
    {
        public int createAccount(long customerid, long accountid, string type, string accstatus, string accmessage, long balance, DateTime updatedate)
        {
            Iaccount account = new account(customerid, accountid, type, accstatus, accmessage, balance, updatedate);
            IOperations operation = new Operations();
            int rowsaff= operation.addAccount(account);
            return rowsaff;
        }

        public int deleteAccount(long customerid, long accountid, string type, string accstatus, string accmessage, long balance, DateTime updatedate)
        {
            Iaccount account = new account(customerid, accountid, type, accstatus, accmessage, balance, updatedate);
            IOperations operation = new Operations();
            int rowsaff = operation.deleteAccount(account);
            return rowsaff;
        }

        public List<Iaccount> viewAccountID(long accountid,long cusid)
        {
            Iaccount account = new account();
            IOperations operation = new Operations();

            List<Iaccount> acclist = operation.ViewAccountID(accountid, cusid);
            return acclist;
        }

        public List<Iaccount> retriveaccount(long accountid)
        {
            IAccountSearchAndDetials accdb = new AccountSearchAndDetials();
            List<Iaccount> accounts = new List<Iaccount>();
            accounts = accdb.RetiveAccountDetials(accountid);
            return accounts;
        }
        public List<Iaccount> retriveaccounts(long customerid)
        {
            IAccountSearchAndDetials accdb = new AccountSearchAndDetials();
            List<Iaccount> accounts = new List<Iaccount>();
            accounts = accdb.RetiveAccount(customerid);
            return accounts;
        }
        public List<Iaccount> retrivealldetials()
        {
            IAccountSearchAndDetials accdb = new AccountSearchAndDetials();
            List<Iaccount> accounts = new List<Iaccount>();
            accounts = accdb.RetiveAllAccountDetials();
            return accounts;
        }
    }
}

