using ProductList.BusinessLayer.Interface;
using ProductList.DataAccessLayer.Interface;
using ProductList.Models.Models.Domain;
using ProductList.Models.Models.Dto;

namespace ProductList.BusinessLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        { 
            _productRepository = productRepository;
        }

        public List<Product> GetAllProducts()
        {
            var products = _productRepository.GetAllProducts();
            return products;
        }
        public Product GetProductById(int productId)
        {
            var product = _productRepository.GetProductById(productId);
            return product;
        }
        public void AddProduct(ProductDto product)
        {
            _productRepository.AddProduct(product);
        }

        public Product UpdateProduct(int productId, ProductDto updateProduct)
        {
           var product = _productRepository.UpdateProduct(productId, updateProduct);
            return product;
        }
        public Product DeleteProduct(int productId)
        {
            var product = _productRepository.DeleteProduct(productId);
            return product;
        }
    }
}
