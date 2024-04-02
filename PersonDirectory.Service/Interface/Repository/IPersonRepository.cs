using PersonDirectory.DTO;

namespace PersonDirectory.Service.Interface.Repository;

public interface IPersonRepository : IRepositoryBase<Person>
{
    List<Person> GetPersonRelation(DTO.Type relationType);
}

