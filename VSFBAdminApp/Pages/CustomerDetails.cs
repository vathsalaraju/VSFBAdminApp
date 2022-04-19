using Microsoft.AspNetCore.Components;
using VSFBAdminApp.Services;
using VSFBankModels.Models;

namespace VSFBAdminApp.Pages
{
    public partial class CustomerDetails
    {
        [Inject]
        public ICustomerDataService customerAccDataservice { get; set; }
        [Parameter]
        public string CustomerId { get; set; }
        public Customer customer { get; set; } = new Customer();
        protected override async Task OnInitializedAsync()
        {
            customer = (await customerAccDataservice.GetCustomerDetails(CustomerId));
        }
    }
}
