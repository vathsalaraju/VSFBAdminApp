using Microsoft.AspNetCore.Components;
using VSFBAdminApp.Services;
using VSFBankModels.Models;

namespace VSFBAdminApp.Pages
{
    public partial class CustomerAccDetails
    {
        [Parameter]
        public string CustomerId { get; set; }
        public CustomerAcc customerAcc { get; set; } = new CustomerAcc();

        [Inject]
        public ICustomerAccountsDataService customerAccDataservice { get; set; }
       
        protected override async Task OnInitializedAsync()
        {
            customerAcc = await customerAccDataservice.GetCustomerAccountsById(CustomerId);
        }
    }
}
