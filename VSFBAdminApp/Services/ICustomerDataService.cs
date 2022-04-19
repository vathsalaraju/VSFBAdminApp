using VSFBankModels.Models;

namespace VSFBAdminApp.Services
{
    public interface ICustomerDataService
    {
        Task<IEnumerable<Customer>> GetAllCustomer();
        Task<Customer> GetCustomerDetails(string customerId);
        Task<Customer> AddCustomer(Customer cust);
        Task UpdateCustomer(string customerId,Customer cust);
        Task DeleteCustomer(string CustomerId);
    }
}
