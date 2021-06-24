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
    public class TransactionBLL : ITransactionBLL
    {
        public long withdrawdeposit(long Accountid,DateTime Date,string Description,long Amount, long Toaccountid)
        {
            ITransactionDB transdb = new TransactionDB();
            long transid = transdb.depositwithdraw(new transaction(Accountid, Date, Description, Amount, Toaccountid));
            return transid;
        }
        public List<Itransaction> retrivetrans(long accountid,int nooftrans)
        {
            List<Itransaction> transacs = new List<Itransaction>();
            ITransactionDB transdb = new TransactionDB();
            transacs = transdb.retrivetransaction(accountid, nooftrans);
            return transacs;
        }
        public List<Itransaction> retrivetransactionbydate(long accountid,DateTime startdate,DateTime enddate)
        {
            List<Itransaction> transacs = new List<Itransaction>();
            ITransactionDB transdb = new TransactionDB();
            transacs = transdb.retrivetransactionbydate(accountid, startdate, enddate);
            return transacs;

        }
    }
}
