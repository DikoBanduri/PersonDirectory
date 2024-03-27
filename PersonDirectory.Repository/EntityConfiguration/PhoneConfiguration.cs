using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonDirectory.DTO;

namespace PersonDirectory.Repository.EntityConfiguration;

public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
{
    public void Configure(EntityTypeBuilder<Phone> modelBuilder)
    {
        modelBuilder.Property(p => p.PhoneType).HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasAnnotation("MinLength", 4);
        modelBuilder.Property(p => p.IsDelete).HasColumnType("bit");
        modelBuilder.Property(p => p.CreateDate).HasColumnType("datetime");
        modelBuilder.HasOne(p => p.People).WithMany(p => p.PhoneNumbers).OnDelete(DeleteBehavior.NoAction);
    }
}
