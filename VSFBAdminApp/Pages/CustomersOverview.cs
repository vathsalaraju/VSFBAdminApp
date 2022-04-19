using Microsoft.AspNetCore.Components;
using VSFBAdminApp.Services;
using VSFBankModels.Models;

namespace VSFBAdminApp.Pages
{
    public partial class CustomersOverview
    {
        public IEnumerable<Customer> cust { get; set; }
        [Inject]
        public ICustomerDataService customerDataservice { get; set; }
        public IEnumerable<Customer> customers { get; set; }
        protected override async Task OnInitializedAsync()
        {
            customers = (await customerDataservice.GetAllCustomer()).ToList();
        }
    }
}
