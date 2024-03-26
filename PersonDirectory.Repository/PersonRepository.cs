using PersonDirectory.DTO;
using PersonDirectory.Service.Interface.Repository;

namespace PersonDirectory.Repository;

internal sealed class PersonRepository : RepositoryBase<Person>, IPersonRepository
{
    internal PersonRepository(DirectoryDbContext context) : base(context)
    {

    }
}
