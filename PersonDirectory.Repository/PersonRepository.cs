using Microsoft.EntityFrameworkCore;
using PersonDirectory.DTO;
using PersonDirectory.Service.Interface.Repository;

namespace PersonDirectory.Repository;

internal sealed class PersonRepository : RepositoryBase<Person>, IPersonRepository
{
    protected readonly DirectoryDbContext _context;

    internal PersonRepository(DirectoryDbContext context) : base(context)
    {

    }

    public List<Person> GetPersonRelation(DTO.Type relationType)
    {
        return _context.Relations
            .Where(r => r.Type == relationType)
            .Select(r => r.FromPerson)
            .ToList();
    }
}