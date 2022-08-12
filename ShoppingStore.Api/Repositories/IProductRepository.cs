using ShoppingStore.Api.Entities;

namespace ShoppingStore.Api.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
