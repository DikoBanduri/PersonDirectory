using Microsoft.EntityFrameworkCore;
using PersonDirectory.Repository;
using PersonDirectory.Service.Interface;
using PersonDirectory.Service.Interface.IService;
using PersonDirectory.Service.Interface.Repository;


namespace PersonDirectory.Api.Configuration;

public static class DependencyConfiguration
{
    public static void ConfigureDependency(this WebApplicationBuilder builder)
    {
        if (builder == null) throw new ArgumentNullException(nameof(builder));

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddScoped<IPersonService, PersonService>();
        //builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddDbContext<DirectoryDbContext>(options => options.UseSqlServer(connectionString));
    }
}