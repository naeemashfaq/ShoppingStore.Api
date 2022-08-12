using Microsoft.EntityFrameworkCore;
using ShoppingStore.Api.Data;
using ShoppingStore.Api.Entities;

namespace ShoppingStore.Api.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly ShoppingStoreDbContext _context;
        public CustomerRepository(ShoppingStoreDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetItems()
        {
            //var cust = await _context.Customers.Where(p => p.Promotion.Any(s=>s.Id == p.Id)).ToListAsync();

           var customers = await _context.Customers
                .Include(p => p.Promotion)
                .Where(p => p.Promotion.Count() > 0).ToListAsync();
           return customers;

        }
    }
}
