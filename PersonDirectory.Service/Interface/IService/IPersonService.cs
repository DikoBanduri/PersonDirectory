using PersonDirectory.DTO;

namespace PersonDirectory.Service.Interface.IService;

public interface IPersonService
{
    void CreatePerson(Person person);
    void UpdatePerson(Person person);
    void DeletePerson(int personId);
}
