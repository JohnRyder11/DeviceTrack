using DeviceTracking.Entity.Models.Device;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeviceTracking.Dal.Concrete.EntityFramework.Context
{
    public class CihazConfiguration : IEntityTypeConfiguration<Cihaz>
    {
        public void Configure(EntityTypeBuilder<Cihaz> builder)
        {
            builder.ToTable("Cihaz", "Device");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        }
    }

    public class CihazParcaConfiguration : IEntityTypeConfiguration<CihazParca>
    {
        public void Configure(EntityTypeBuilder<CihazParca> builder)
        {
            builder.ToTable("CihazParca", "Device");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder.HasOne(x => x.Cihaz).WithMany().HasForeignKey(x => x.CihazId).IsRequired();
        }
    }


    public class KullaniciConfiguration : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.ToTable("Kullanici", "Device");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);
            builder.Property(x => x.AdSoyad).IsRequired().HasMaxLength(50);
        }
    }
}