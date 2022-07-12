using Microsoft.EntityFrameworkCore;
using ProductStoreAPI.Entities;

namespace ProductStoreAPI
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options):base(options)
        {

        }

        DbSet<Product> Products { get; set; }
    }
}
