using Microsoft.EntityFrameworkCore;

namespace azure_app_mrinmoy.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        
       
        }

        public DbSet<Person> persons { get; set; }   
    }
}
