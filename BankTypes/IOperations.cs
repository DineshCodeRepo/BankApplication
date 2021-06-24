using BankTypes;
using System.Collections.Generic;

namespace BankDAL
{
    public interface IOperations
    {
        int addCustomer(ICustomer customer);
        int updateCustomer(ICustomer customer);
        List<ICustomer> retriveCusDetails(long cusid,long customerssnid);
        int deleteCustomer(ICustomer customer);

        int addAccount(Iaccount account);
        int deleteAccount(Iaccount account);
        List<Iaccount> ViewAccountID(long accountid, long cusid);
        List<ICustomer> viewall();
    }
}