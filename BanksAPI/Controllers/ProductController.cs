using Banks.SQL.Product;
using BanksAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BanksAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("products")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }
        [HttpGet("products/{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost("products")]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            await _productService.AddProductAsync(product);
            return CreatedAtAction(nameof(GetProductById), new { id = product.ProductId }, product);
        }
        [HttpPut("products/{id}")]
        public async Task<IActionResult> UpdateProduct(Guid id, [FromBody] Product product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }
            await _productService.UpdateProductAsync(product);
            return NoContent();
        }
        [HttpDelete("products/{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            await _productService.DeleteProductAsync(id);
            return NoContent();
        }
        [HttpGet("issues")]
        public async Task<IActionResult> GetAllIssues()
        {
            var issues = await _productService.GetAllIssuesAsync();
            return Ok(issues);
        }
        [HttpGet("issues/{id}")]
        public async Task<IActionResult> GetIssueById(Guid id)
        {
            var issue = await _productService.GetIssueByIdAsync(id);
            if (issue == null)
            {
                return NotFound();
            }
            return Ok(issue);
        }
        [HttpPost("issues")]
        public async Task<IActionResult> AddIssue([FromBody] Issue issue)
        {
            await _productService.AddIssueAsync(issue);
            return CreatedAtAction(nameof(GetIssueById), new { id = issue.IssueId }, issue);
        }

        [HttpPut("issues/{id}")]
        public async Task<IActionResult> UpdateIssue(Guid id, [FromBody] Issue issue)
        {
            if (id != issue.IssueId)
            {
                return BadRequest();
            }
            await _productService.UpdateIssueAsync(issue);
            return NoContent();
        }

        [HttpDelete("issues/{id}")]
        public async Task<IActionResult> DeleteIssue(Guid id)
        {
            await _productService.DeleteIssueAsync(id);
            return NoContent();
        }
    }
}
