using Microsoft.EntityFrameworkCore;
using ProductManagement.Providers;
using ProductManagemnt.Data;

namespace ProductManagement.Data
{
    public class DefaultContext : ContextTables { public DefaultContext(Connection connection) : base() { CurrentConnection = connection; } }
    public class ContextTables : ContextProvider
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }   
    }
}
