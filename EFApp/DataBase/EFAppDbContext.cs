using Microsoft.EntityFrameworkCore;

namespace EFApp.DataBase
{
    public class EFAppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=SkyCote36;Database=efapp");
        }

        public DbSet<AutoEntity> Autos { get; set; }
        public DbSet<OwnerEntity> Owners { get; set; }
    }
}
