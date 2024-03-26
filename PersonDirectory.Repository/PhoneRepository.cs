using PersonDirectory.DTO;
using PersonDirectory.Service.Interface.Repository;

namespace PersonDirectory.Repository;

internal sealed class PhoneRepository : RepositoryBase<Phone>, IPhoneRepository
{
    internal PhoneRepository(DirectoryDbContext context) : base(context)
    {

    }
}
