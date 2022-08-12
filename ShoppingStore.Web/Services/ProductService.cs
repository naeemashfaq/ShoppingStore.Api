using ShoppingStore.Api.Entities;

namespace ShoppingStore.Web.Services
{
    public class ProductService:IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetProduct()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>("api/Products/GetProduct");
                  
        }
    }
}
