using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingStore.Api.Entities;
using ShoppingStore.Api.Repositories;

namespace ShoppingStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        [Route("GetProduct")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            var prod = await _productRepository.GetProducts();
            List<Product> product = new List<Product>();
            return Ok(prod);
        }
    }

}
