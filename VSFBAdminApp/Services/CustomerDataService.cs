using System.Text;
using System.Text.Json;
using VSFBankModels.Models;

namespace VSFBAdminApp.Services
{
    public class CustomerDataService : ICustomerDataService
    {
        private readonly HttpClient _httpClient;

        public CustomerDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Customer> AddCustomer(Customer cust)
        {
            var CustomerJson =
                new StringContent(JsonSerializer.Serialize(cust), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Customers", CustomerJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Customer>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task DeleteCustomer(string customerId)
        {
            await _httpClient.DeleteAsync($"api/Customers/{customerId}");
        }

        public async Task<IEnumerable<Customer>> GetAllCustomer()
        {
            var datajson = await _httpClient.GetStreamAsync($"api/Customers");//returns data in stream format
            var data = await JsonSerializer.DeserializeAsync<IEnumerable<Customer>>(await _httpClient.GetStreamAsync($"api/customers"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            return data;
        }

        public async Task<Customer> GetCustomerDetails(string customerId)
        {
            return await JsonSerializer.DeserializeAsync<Customer>
                (await _httpClient.GetStreamAsync($"api/customers/{customerId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateCustomer(string customerId,Customer cust)
        {
            var customerJson =
                new StringContent(JsonSerializer.Serialize(cust), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/customers", customerJson);
        }
    }
}
