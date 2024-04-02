using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonDirectory.DTO;

namespace PersonDirectory.Repository.EntityConfiguration;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> modelBuilder)
    {
        modelBuilder.Property(c => c.Name).HasColumnType("nvarchar(50)").IsRequired();
        modelBuilder.HasIndex(c => c.Name).IsUnique();
        modelBuilder.Property(c => c.CreateDate).HasColumnType("datetime");
        modelBuilder.Property(c => c.IsDelete).HasColumnType("bit");
        modelBuilder.HasMany(c => c.People).WithOne(c => c.City).OnDelete(DeleteBehavior.NoAction);

    }
}