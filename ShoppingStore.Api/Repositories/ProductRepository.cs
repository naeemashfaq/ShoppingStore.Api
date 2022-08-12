using Microsoft.EntityFrameworkCore;
using ShoppingStore.Api.Data;
using ShoppingStore.Api.Entities;

namespace ShoppingStore.Api.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly ShoppingStoreDbContext _context;

        public ProductRepository(ShoppingStoreDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Product>> GetProducts()
        {
           var products = await _context.Products
                .Include(p => p.Promotion).ToListAsync();
            var temp = products;
            var temp2 = temp;

            return products;
        }
    }
}
