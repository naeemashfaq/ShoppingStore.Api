using ShoppingStore.Api.Entities;

namespace ShoppingStore.Web.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProduct();
    }
}
