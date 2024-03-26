using PersonDirectory.DTO;
using PersonDirectory.Service.Interface.Repository;

namespace PersonDirectory.Repository;

internal sealed class RelationRepository : RepositoryBase<Relation>, IRelationRepository
{
    internal RelationRepository(DirectoryDbContext context) : base(context)
    {

    }
}
