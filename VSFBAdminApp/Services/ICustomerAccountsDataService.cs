using VSFBAdminApp.Models;
using VSFBankModels.Models;

namespace VSFBAdminApp.Services
{
    public interface ICustomerAccountsDataService
    {
        Task<IEnumerable<CustomerAcc>> GetCustomerAccounts();
        Task<CustomerAcc> GetCustomerAccountsById(string id);
    }
}
