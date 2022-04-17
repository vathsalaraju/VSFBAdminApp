using VSFB.Models;

using VSFBankModels.Models;

namespace VSFBAdminApp.Models
{
    public class CustomerAccounts : ICustomerAccounts
    {
        private readonly VSFBankContext _db;

        public CustomerAccounts(VSFBankContext context)
        {
            _db = context;
        }
        public IEnumerable<CustomerAcc> GetCustomerAccs()
        {
            return _db.CustomerAccs;
        }

        public CustomerAcc GetCustomerAccsById(string id)
        {
            return _db.CustomerAccs.FirstOrDefault(c => c.CustomerId == id);
        }

       
    }
}
