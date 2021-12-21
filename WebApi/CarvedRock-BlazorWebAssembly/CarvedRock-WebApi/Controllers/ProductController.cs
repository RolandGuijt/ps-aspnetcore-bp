using CarvedRock_WebApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace CarvedRock_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var products = await productRepository.GetAll();
            if (products.Count() == 0)
                return NoContent();

            return Ok(products);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOne(int id)
        {
            var product = await productRepository.GetOne(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
                
            await productRepository.Add(product);
            return CreatedAtAction(nameof(GetOne), new { id = product.Id }, product);
        }
    }
}