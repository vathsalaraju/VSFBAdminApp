using System.Text;
using System.Text.Json;
using VSFBAdminApp.Models;
using VSFBankModels.Models;

namespace VSFBAdminApp.Services
{
    public class CustomerAccountsDataServices:ICustomerAccountsDataService
    {
            private readonly HttpClient _httpClient;

            public CustomerAccountsDataServices(HttpClient httpClient)
            {
                _httpClient = httpClient;
            }

            public async Task<IEnumerable<CustomerAcc>> GetCustomerAccounts()
            {
            //var datajson = await _httpClient.GetStreamAsync($"api/customerAaccounts");//returns data in stream format
            var data = await JsonSerializer.DeserializeAsync<IEnumerable<CustomerAcc>>(await _httpClient.GetStreamAsync($"api/customeraccounts"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return data;
            //return await HttpClient.GetStreamAsync<CustomerAcc[]>("api/CustomerAccounts");
        }

        public async Task<CustomerAcc> GetCustomerAccountsById(string id)
            {
                return await JsonSerializer.DeserializeAsync<CustomerAcc>
                    (await _httpClient.GetStreamAsync($"api/customeraccounts/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }


        }
    }


