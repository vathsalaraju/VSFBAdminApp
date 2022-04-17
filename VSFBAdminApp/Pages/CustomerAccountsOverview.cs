using Microsoft.AspNetCore.Components;
using VSFBAdminApp.Models;
using VSFBAdminApp.Services;
using VSFBankModels.Models;

namespace VSFBAdminApp.Pages
{
    public partial class CustomerAccountsOverview
    {
        public IEnumerable<CustomerAcc> custAcc { get; set; }
        [Inject]
        public ICustomerAccountsDataService customerAccDataservice { get; set; } 
        public IEnumerable<CustomerAcc> customerAccounts { get; set; }
        protected override async Task OnInitializedAsync()
        {
            customerAccounts = (await customerAccDataservice.GetCustomerAccounts()).ToList();
        }

    }
}
