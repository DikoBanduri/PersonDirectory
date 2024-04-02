using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonDirectory.DTO;

namespace PersonDirectory.Repository.EntityConfiguration;

public class RelationConfiguration : IEntityTypeConfiguration<Relation>
{
    public void Configure(EntityTypeBuilder<Relation> modelBuilder)
    {
        modelBuilder.Property(r => r.Type).HasColumnType("nvarchar").IsRequired(true);
        modelBuilder.Property(p => p.CreateDate).IsRequired(true).HasColumnType("datetime");
        modelBuilder.Property(p => p.IsDelete).IsRequired(true).HasColumnType("Bit");
        modelBuilder.HasOne(r => r.FromPerson).WithMany(p => p.FromRelations).HasForeignKey(r => r.FromId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.HasOne(r => r.ToPerson).WithMany(p => p.ToRelations).HasForeignKey(r => r.ToId).OnDelete(DeleteBehavior.NoAction);
    }
}