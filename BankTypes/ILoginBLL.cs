using System.Collections.Generic;
using BankTypes;

namespace BankTypes
{
    public interface ILoginBLL
    {
        List<Ilogin> retriveuser(string username);
    }
}