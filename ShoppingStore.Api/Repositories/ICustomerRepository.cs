using ShoppingStore.Api.Entities;

namespace ShoppingStore.Api.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetItems();
    }
}
