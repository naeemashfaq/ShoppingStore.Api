using ShoppingStore.Api.Entities;

namespace ShoppingStore.Web.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomer();
    }
}
