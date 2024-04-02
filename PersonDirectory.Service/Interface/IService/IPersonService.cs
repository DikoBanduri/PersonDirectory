using PersonDirectory.DTO;
using System.Linq.Expressions;

namespace PersonDirectory.Service.Interface.IService;

public interface IPersonService
{
    Task<Person> GetById(int id);
    Task<IEnumerable<Person>> GetPeople();
    void Insert(Person person);
    void Update(Person person);
    void Delete(int id);
}
