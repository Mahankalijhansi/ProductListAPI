using ProductList.Models.Models.Domain;
using ProductList.Models.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductList.BusinessLayer.Interface
{
    public interface IProductService
    {
        public List<Product> GetAllProducts();
        public Product GetProductById(int productId);
        public void AddProduct(ProductDto product);

        public Product UpdateProduct(int productId, ProductDto product);
        public Product DeleteProduct(int productId);
    }
}
