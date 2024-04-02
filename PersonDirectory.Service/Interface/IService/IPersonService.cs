using PersonDirectory.DTO;

namespace PersonDirectory.Service.Interface.IService;

public interface IPersonService
{
    IEnumerable<Person> GetPeople();
    Person GetById(int  id);
    List<Person> GetPersonRelation(DTO.Type relationType);
    void CreatePerson(Person person);
    void UpdatePerson(Person person);
    void DeletePerson(int personId);
}
