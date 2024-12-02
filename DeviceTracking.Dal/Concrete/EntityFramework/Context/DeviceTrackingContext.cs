using Microsoft.EntityFrameworkCore;

namespace DeviceTracking.Dal.Concrete.EntityFramework.Context
{
    public class DeviceTrackingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source = DbNorthwind; Initial Catalog = DeviceTrack; Integrated Security = true; TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Server=***; Database=***; Uid=**; Password=**;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CihazConfiguration());
            modelBuilder.ApplyConfiguration(new CihazParcaConfiguration());
            modelBuilder.ApplyConfiguration(new KullaniciConfiguration());
        }
    }
}
