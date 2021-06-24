using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankTypes;

namespace BankBO
{
    public class login:Ilogin
    {
        string username;
        string password;
        DateTime timestamp;
        int type;

        public login(string username, string password, DateTime timestamp, int type)
        {
            this.username = username;
            this.password = password;
            this.timestamp = timestamp;
            this.type = type;
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public DateTime Timestamp
        {
            get
            {
                return timestamp;
            }

            set
            {
                timestamp = value;
            }
        }

        public int Type
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
    }
}