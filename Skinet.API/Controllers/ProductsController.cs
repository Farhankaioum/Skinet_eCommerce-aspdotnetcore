using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Skinet.Core.Interfaces;

namespace Skinet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepo;

        public ProductsController(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productRepo.GetProductsAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async  Task<IActionResult> GetProductById(int id)
        {
            var product = await _productRepo.GetProductByIdAsync(id);

            return Ok(product);
        }

        [HttpGet("brands")]
        public async Task<IActionResult> GetProductBrands()
        {
            var productBrands = await _productRepo.GetProductBrandsAsync();

            return Ok(productBrands);
        }

        [HttpGet("types")]
        public async Task<IActionResult> GetProductTypes()
        {
            var productTypes = await _productRepo.GetProductTypesAsync();

            return Ok(productTypes);
        }
    }
}
