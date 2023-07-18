using Microsoft.EntityFrameworkCore;

using WTOPMDb.Models;

namespace WTOPMDb.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {} 
    
        public DbSet<Weather> Weathers { get; set; }
    }
}
