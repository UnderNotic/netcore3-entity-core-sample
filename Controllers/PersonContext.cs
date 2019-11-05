using Microsoft.EntityFrameworkCore;

namespace ef101.Controllers
{
    public class PersonContext : DbContext
    {
        public DbSet<PersonEntity> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres");
        }
    }
}