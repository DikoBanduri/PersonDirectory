using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using PersonDirectory.DTO;

namespace PersonDirectory.Repository;

public class DirectoryDbContext : DbContext
{
    public DirectoryDbContext(DbContextOptions<DirectoryDbContext> options) : base(options)
    {

    }

    public DbSet<City> Cities { get; set; }
    public DbSet<Person> People { get; set; }
    public DbSet<Phone> Phones { get; set; }
    public DbSet<Relation> Relations { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer("Server=DESKTOP-KDGMEN7/dikob;Database=DPersonDirectory;trusted_Connection=true;TrustServerCertificate=True");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<City>().Property(c => c.Name).HasColumnType("nvarchar(50)").IsRequired(true);
        modelBuilder.Entity<City>().HasIndex(c => c.Name).IsUnique(true);
        modelBuilder.Entity<City>().Property(c => c.CreateDate).HasColumnType("datetime");
        modelBuilder.Entity<City>().Property(c => c.IsDelete).HasColumnType("bit");
        modelBuilder.Entity<City>().HasMany(c => c.People).WithOne(c => c.City);

        modelBuilder.Entity<Person>().Property(p => p.FirstName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired(true).HasAnnotation("MinLength", 2);
        modelBuilder.Entity<Person>().Property(p => p.LastName).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(50).HasAnnotation("MinLength", 2);
        modelBuilder.Entity<Person>().Property(p => p.PIN).HasColumnType("nvarchar(11)").IsRequired(true);
        modelBuilder.Entity<Person>().Property(p => p.BirthDate).IsRequired(true).HasColumnType("date").HasAnnotation("CheckConstraint", "DateOfBirth <= DateAdd(Year, -18, GetDate())");
        modelBuilder.Entity<Person>().HasMany(c => c.PhoneNumbers).WithOne(c => c.People);
        modelBuilder.Entity<Person>().Property(p => p.CreateDate).IsRequired(true).HasColumnType("datetime");
        modelBuilder.Entity<Person>().Property(p => p.IsDelete).IsRequired(true).HasColumnType("Bit");

        modelBuilder.Entity<Relation>().Property(r => r.Type).IsRequired(true);
        modelBuilder.Entity<Relation>().Property(p => p.CreateDate).IsRequired(true).HasColumnType("datetime");
        modelBuilder.Entity<Relation>().Property(p => p.IsDelete).IsRequired(true).HasColumnType("Bit");
        modelBuilder.Entity<Relation>().HasOne(r => r.FromPerson).WithMany(p => p.FromRelations).HasForeignKey(r => r.FromId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Relation>().HasOne(r => r.ToPerson).WithMany(p => p.ToRelations).HasForeignKey(r => r.ToId).OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Phone>().Property(p => p.Personal).HasColumnType("nvarchar").IsRequired(true).HasMaxLength(50).HasAnnotation("MinLength", 4);
        modelBuilder.Entity<Phone>().Property(p => p.Home).HasColumnType("nvarchar").IsRequired(false).HasMaxLength(50).HasAnnotation("MinLength", 4);
        modelBuilder.Entity<Phone>().Property(p => p.Office).HasColumnType("nvarchar").IsRequired(false).HasMaxLength(50).HasAnnotation("MinLength", 4);
        modelBuilder.Entity<Phone>().Property(p => p.Additional).HasColumnType("nvarchar").IsRequired(false).HasMaxLength(50).HasAnnotation("MinLength", 4);
        modelBuilder.Entity<Phone>().Property(p => p.IsDelete).HasColumnType("bit");
        modelBuilder.Entity<Phone>().Property(p => p.CreateDate).HasColumnType("datetime");
        modelBuilder.Entity<Phone>().HasOne(p => p.People).WithMany(p => p.PhoneNumbers);
    }
}