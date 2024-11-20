using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFApp.DataBase
{
    public class OwnerConfigurations : IEntityTypeConfiguration<OwnerEntity>
    {
        public void Configure(EntityTypeBuilder<OwnerEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(n => n.Name).IsRequired();
            builder.Property(a => a.Age).IsRequired();
        }
    }
}
