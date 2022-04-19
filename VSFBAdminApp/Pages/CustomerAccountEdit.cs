using Microsoft.AspNetCore.Components;
using VSFBAdminApp.Services;
using VSFBankModels.Models;

namespace VSFBAdminApp.Pages
{
    public partial class CustomerAccountEdit
    {
        [Inject]
        public ICustomerAccountsDataService customerAccDataservice { get; set; }
        [Parameter]
        public string CustomerId { get; set; }
        public CustomerAcc customerAcc { get; set; } = new CustomerAcc();
        protected override async Task OnInitializedAsync()
        {
            customerAcc = (await customerAccDataservice.GetCustomerAccountsById(CustomerId));
        }
        protected async Task UpdateData()
        {
            await customerAccDataservice.UpdateCustomerAccount(CustomerId,customerAcc);

        }
    }
}
