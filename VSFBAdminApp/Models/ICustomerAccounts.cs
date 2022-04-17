using VSFBankModels.Models;

namespace VSFBAdminApp.Models
{
    public interface ICustomerAccounts
    {
        IEnumerable<CustomerAcc> GetCustomerAccs();
        CustomerAcc GetCustomerAccsById(string id);
    }
}
