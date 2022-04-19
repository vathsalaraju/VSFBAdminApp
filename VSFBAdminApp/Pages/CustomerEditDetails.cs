using Microsoft.AspNetCore.Components;
using VSFBAdminApp.Services;
using VSFBankModels.Models;

namespace VSFBAdminApp.Pages
{
    public partial class CustomerEditDetails
    {

        [Inject]
        public ICustomerDataService customerDataservice { get; set; }
        [Parameter]
        public string CustomerId { get; set; }
        public Customer customer { get; set; } = new Customer();
        protected override async Task OnInitializedAsync()
        {
            customer = (await customerDataservice.GetCustomerDetails(CustomerId));
        }

        protected async Task UpdateCustomerData()
        {
            await customerDataservice.UpdateCustomer(CustomerId, customer);

        }
    }
}
