using Microsoft.EntityFrameworkCore;
using ProductList.Models.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductList.DataAccessLayer.Context
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
    }
}
