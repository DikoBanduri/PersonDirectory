using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonDirectory.DTO;

namespace PersonDirectory.Repository.EntityConfiguration;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> modelBuilder)
    {
        modelBuilder.Property(p => p.FirstName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired(true).HasAnnotation("MinLength", 2);
        modelBuilder.Property(p => p.LastName).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(50).HasAnnotation("MinLength", 2);
        modelBuilder.Property(p => p.PIN).HasColumnType("nvarchar(11)").IsRequired(true);
        modelBuilder.Property(p => p.BirthDate).IsRequired(true).HasColumnType("date");
        modelBuilder.Property(p => p.CreateDate).IsRequired(true).HasColumnType("datetime");
        modelBuilder.Property(p => p.IsDelete).IsRequired(true).HasColumnType("Bit");
        modelBuilder.HasMany(c => c.PhoneNumbers).WithOne(c => c.People).OnDelete(DeleteBehavior.NoAction);
    }
}