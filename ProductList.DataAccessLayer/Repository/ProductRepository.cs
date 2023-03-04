using AutoMapper;
using ProductList.DataAccessLayer.Context;
using ProductList.DataAccessLayer.Interface;
using ProductList.Models.Models.Domain;
using ProductList.Models.Models.Dto;


namespace ProductList.DataAccessLayer.Repository
{
    public class ProductRepository :IProductRepository
    {
        private readonly ProductDbContext _context;
        private readonly IMapper _mapper;
        public ProductRepository(ProductDbContext context,IMapper mapper) 
        { 
            _context= context;
            _mapper= mapper;
        }
        public List<Product> GetAllProducts()
        {
           return _context.Product.ToList();
        }

        public Product GetProductById(int productId)
        {
            var product= _context.Product.SingleOrDefault(p => p.ProductId == productId);
            if(product != null)
                return product;
            return null;
        }

        public void AddProduct(ProductDto addproduct)
        {
            var product = _mapper.Map<ProductDto, Product>(addproduct);
            _context.Product.Add(product);
            _context.SaveChanges();
        }

        public Product UpdateProduct(int productId, ProductDto updateProduct)
        {
            var product = _context.Product.SingleOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                _mapper.Map(updateProduct, product);
                _context.SaveChanges();
                return product;
            }
            return null;
        }

        public Product DeleteProduct(int productId) {
            var product = _context.Product.SingleOrDefault(p=>p.ProductId== productId);
            if (product != null)
            {
                _context.Product.Remove(product);
                _context.SaveChanges();
                return product;
            }
            return null; 
        }
    }
}
