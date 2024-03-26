using PersonDirectory.DTO;
using PersonDirectory.Service.Interface.Repository;

namespace PersonDirectory.Repository;

internal sealed class CityRepository : RepositoryBase<City>, ICityRepository
{
    internal CityRepository(DirectoryDbContext context) : base(context)
    { 
    
    }
}
