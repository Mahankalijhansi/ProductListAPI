using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ProductList.BusinessLayer.Interface;
using ProductList.Models.Models.Dto;

namespace ProductListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductController(IProductService service) 
        { 
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _service.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{productId}")]
        public IActionResult GetProductById( int productId)
        {
            var product = _service.GetProductById(productId);
            if (product != null)
                return Ok(product);
            throw new Exception("404: NOT FOUND");
        }

        [HttpPost]
        public IActionResult AddProduct(ProductDto product)
        {
            _service.AddProduct(product);
            return Ok(product);
        }

        [HttpPut("{productId}")]
        public IActionResult UpdateProduct(int productId, ProductDto updateProduct)
        {
           var product= _service.UpdateProduct(productId, updateProduct);
            if (product != null)
                return Ok(product);
            throw new Exception("404: NOT FOUND");
        }

        [HttpDelete("{productId}")]
        public IActionResult DeleteProduct(int productId)
        {
            var product = _service.DeleteProduct(productId);
            if (product != null)
                return Ok(product);
            throw new Exception("404: NOT FOUND");
        }
    }

}
