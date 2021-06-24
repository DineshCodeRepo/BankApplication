using System.Collections.Generic;

namespace BankTypes
{
    public interface ILoginDB
    {
        List<Ilogin> retriveuser(string username);
    }
}