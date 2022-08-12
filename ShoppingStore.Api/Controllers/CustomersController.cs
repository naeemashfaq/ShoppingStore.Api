using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingStore.Api.Entities;
using ShoppingStore.Api.Repositories;


namespace ShoppingStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        [Route("GetCustomer")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomer()
        {
            var cust = await _customerRepository.GetItems();
            List<Customer> customer = new List<Customer>();
            return Ok(cust);
        }
    }


}
