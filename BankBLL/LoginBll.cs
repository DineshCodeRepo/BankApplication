using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankTypes;
using BankDAL;


namespace BankBLL
{
    public class LoginBLL : ILoginBLL
    {
        public List<Ilogin> retriveuser(string username)
        {

            List<Ilogin> user = new List<Ilogin>();
            ILoginDB logindb = new LoginDB();
            user = logindb.retriveuser(username);
            return user;
        }
            
    }
}
