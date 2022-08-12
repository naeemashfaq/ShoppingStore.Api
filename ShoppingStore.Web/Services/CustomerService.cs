using ShoppingStore.Api.Entities;

namespace ShoppingStore.Web.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly HttpClient _httpClient;

        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Customer>> GetCustomer()
        {
            return await _httpClient.GetFromJsonAsync<List<Customer>>("api/Customers/GetCustomer");
;        }
    }
}
