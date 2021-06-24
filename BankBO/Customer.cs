using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankTypes;

namespace BankBO
{
    public class Customer:ICustomer
    {
        long customerssnid;
        long customerid;
        string customername;
        int age;
        string address;
        string city;
        string state;
        string cusstatus;
        string cusmessage;
        DateTime updatedate;

        public Customer(long customerssnid, long customerid, string customername, int age, string address, string city, string state, string cusstatus, string cusmessage, DateTime updatedate)
        {
            this.customerssnid = customerssnid;
            this.customerid = customerid;
            this.customername = customername;
            this.age = age;
            this.address = address;
            this.city = city;
            this.state = state;
            this.cusstatus = cusstatus;
            this.cusmessage = cusmessage;
            this.updatedate = updatedate;
        }

        public Customer(long customerssnid, long customerid, string customername, int age, string address)
        {
            this.customerssnid = customerssnid;
            this.customerid = customerid;
            this.customername = customername;
            this.age = age;
            this.address = address;
        }

        public long Customerssnid
        {
            get
            {
                return customerssnid;
            }

            set
            {
                customerssnid = value;
            }
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

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public string Cusstatus
        {
            get
            {
                return cusstatus;
            }

            set
            {
                cusstatus = value;
            }
        }

        public string Cusmessage
        {
            get
            {
                return cusmessage;
            }

            set
            {
                cusmessage = value;
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

        public string Customername
        {
            get
            {
                return customername;
            }

            set
            {
                customername = value;
            }
        }
    }
}