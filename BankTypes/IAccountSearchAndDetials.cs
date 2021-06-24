using System.Collections.Generic;

namespace BankTypes
{
    public interface IAccountSearchAndDetials
    {
        List<Iaccount> RetiveAccount(long customerid);
        List<Iaccount> RetiveAccountDetials(long accountid);
        List<Iaccount> RetiveAllAccountDetials();
    }
}