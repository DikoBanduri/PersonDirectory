using PersonDirectory.DTO;
using Microsoft.EntityFrameworkCore;
using PersonDirectory.Repository.EntityConfiguration;

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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new CityConfiguration());
        modelBuilder.ApplyConfiguration(new PersonConfiguration());
        modelBuilder.ApplyConfiguration(new PhoneConfiguration());
        modelBuilder.ApplyConfiguration(new RelationConfiguration());
    }
}