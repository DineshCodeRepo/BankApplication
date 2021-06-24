using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankTypes;

namespace BankBO
{
    public class account :Iaccount
    {
        long customerid;
        long accountid;
        string type;
        string accstatus;
        string accmessage;
        long balance;
        DateTime updatedate;

        public account()
        { }

        public account(long customerid, long accountid, string type, string accstatus, string accmessage, long balance, DateTime updatedate)
        {
            this.customerid = customerid;
            this.accountid = accountid;
            this.type = type;
            this.accstatus = accstatus;
            this.accmessage = accmessage;
            this.balance = balance;
            this.Updatedate = updatedate;
        }

        public long Customerid
        {
            get
            {
                return customerid;
            }

            set
            {
                customerid = value;
            }
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

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Accstatus
        {
            get
            {
                return accstatus;
            }

            set
            {
                accstatus = value;
            }
        }

        public string Accmessage
        {
            get
            {
                return accmessage;
            }

            set
            {
                accmessage = value;
            }
        }

        public long Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public DateTime Updatedate
        {
            get
            {
                return updatedate;
            }

            set
            {
                updatedate = value;
            }
        }
    }
}