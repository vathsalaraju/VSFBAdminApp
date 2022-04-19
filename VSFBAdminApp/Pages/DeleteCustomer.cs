using Microsoft.AspNetCore.Components;
using VSFBAdminApp.Services;
using VSFBankModels.Models;

namespace VSFBAdminApp.Pages
{
    public partial class DeleteCustomer
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

        protected async Task DeleteCustomerData()
        {
            await customerDataservice.DeleteCustomer(CustomerId);
        }
    }
}
