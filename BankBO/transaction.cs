using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankTypes;

namespace BankBO
{
    public class transaction:Itransaction
    {
        long accountid;
        long transactionid;
        DateTime date;
        string description;
        long amount;
        long toaccountid;

        public transaction(long accountid, DateTime date, string description, long amount, long toaccountid, long transactionid = 0)
        {
            this.accountid = accountid;
            this.transactionid = transactionid;
            this.date = date;
            this.description = description;
            this.amount = amount;
            this.toaccountid = toaccountid;
        }

        public long Accountid
        {
            get
            {
                return accountid;
            }

            set
            {
                accountid = value;
            }
        }

        public long Transactionid
        {
            get
            {
                return transactionid;
            }

            set
            {
                transactionid = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public long Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public long Toaccountid
        {
            get
            {
                return toaccountid;
            }

            set
            {
                toaccountid = value;
            }
        }
    }
}