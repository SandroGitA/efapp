using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFApp.DataBase
{
    public class AutoConfigurations : IEntityTypeConfiguration<AutoEntity>
    {
        public void Configure(EntityTypeBuilder<AutoEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(n => n.Name).IsRequired();
            builder.Property(m => m.Model).IsRequired();
            builder.Property(y => y.YearOfIssue).IsRequired();
            builder.Property(c => c.Country).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasOne(o => o.Owner)
                .WithMany(a => a.Autos)
                .HasForeignKey(o => o.OwnerEntityId);
        }
    }
}
