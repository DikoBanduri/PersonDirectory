using PersonDirectory.DTO;
using PersonDirectory.Service.Interface.IService;
using PersonDirectory.Service.Interface.Repository;

namespace PersonDirectory.Service.Interface;

public sealed class PersonService : IPersonService
{
    private readonly IUnitOfWork _unitOfWork;

    public PersonService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public void CreatePerson(Person person)
    {
        if (person == null) throw new ArgumentNullException("person is not found");

        _unitOfWork.PersonRepository.Insert(person);
        _unitOfWork.SaveChanges();
    }

    public Person GetById(int id)
    {
        var person = _unitOfWork.PersonRepository.Get(id);
        return person;
    }

    public void DeletePerson(int personId)
    {
        var person = _unitOfWork.PersonRepository.Get(personId);
        person.IsDelete = true;
        _unitOfWork.PersonRepository.Update(person);
        _unitOfWork.SaveChanges();
    }

    public void UpdatePerson(Person person)
    {
        if (person == null) throw new ArgumentNullException("person is not found");

        _unitOfWork.PersonRepository.Update(person);
        _unitOfWork.SaveChanges();
    }
}
