using PersonDirectory.DTO;
using PersonDirectory.Service.Interface.IService;
using PersonDirectory.Service.Interface.Repository;
using System.Linq.Expressions;

namespace PersonDirectory.Service.Interface;

public sealed class PersonService : IPersonService
{
    private readonly IUnitOfWork _unitOfWork;

    public PersonService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Person> GetById(int id)
    {
        var res = await _unitOfWork.PersonRepository.GetAsync(id);
        return res;
    }

    public async Task<IEnumerable<Person>> GetAllAsync(Expression<Func<Person, bool>> expression) =>
        await _unitOfWork.PersonRepository.GetAllAsync(expression);
  
    public void Insert(Person person)
    {
        if (person != null) throw new ArgumentNullException("Person Id must be empty");

         _unitOfWork.PersonRepository.Insert(person);        
    }

    public void Update(Person person)
    {
        if (person == null) throw new ArgumentNullException("person is not found");

        _unitOfWork.PersonRepository.Update(person);
        _unitOfWork.SaveChanges();
    }

    public void Delete(int id)
    {
        Person person = _unitOfWork.PersonRepository.Get(id) ?? throw new ArgumentNullException("Id does not exist");
        person.IsDelete = true;
        _unitOfWork.PersonRepository.Update(person);
        _unitOfWork.SaveChanges();
    }
}
