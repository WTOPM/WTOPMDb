using Microsoft.EntityFrameworkCore;

using WTOPMDb.Models;

namespace WTOPMDb.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {} 
    
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Field> Fields { get; set; }
    }
}
