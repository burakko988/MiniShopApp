using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using MiniShopApp.Entity;
using MiniShopApp.WebApi.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniShopApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<ActionResult> GetProducts()
        {
            var products = await _productService.GetAll();

            //DTO (DATA TRANSFER OBJECT) kullanarak, veriyi istek sahibine belirlediğimiz bilgileri içerecek şekilde yollayacağız.
            var productsDTO = new List<ProductDTO>();
            foreach (var product in products)
            {
                productsDTO.Add(ProductToDTO(product));
            }
            return Ok(productsDTO);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(ProductToDTO(product));
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product entity)
        {
            await _productService.CreateAsync(entity);
            return CreatedAtAction(nameof(GetProduct), new { id = entity.ProductId }, ProductToDTO(entity));
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product entity)
        {
            if (id != entity.ProductId)
            {
                return BadRequest();
            }
            var product = await _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            await _productService.UpdateProductAsync(product, entity);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            await  _productService.DeleteAsync(product);
            return NoContent();
        }

        private static ProductDTO ProductToDTO(Product product)
        {
            var productDTO = new ProductDTO
            {
                ProductId = product.ProductId,
                Description = product.Description,
                Name = product.Name,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                Url = product.Url
            };
            return productDTO;
        }
    }
}
