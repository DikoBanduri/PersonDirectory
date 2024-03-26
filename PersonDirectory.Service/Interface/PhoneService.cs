using PersonDirectory.DTO;
using PersonDirectory.Service.Interface.IService;
using PersonDirectory.Service.Interface.Repository;

namespace PersonDirectory.Service.Interface;

public sealed class PhoneService : IPhoneService
{
    private readonly IUnitOfWork _unitOfWork;

    public PhoneService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public void CreatePhone(Phone phone)
    {
        if (phone == null) throw new ArgumentNullException("phone is not found");

        _unitOfWork.PhoneRepository.Insert(phone);
        _unitOfWork.SaveChanges();
    }

    public Phone GetById(int id)
    {
        var phone = _unitOfWork.PhoneRepository.Get(id);
        return phone;
    }

    public void DeletePhone(int phoneId)
    {
        var phone = _unitOfWork.PhoneRepository.Get(phoneId);
        phone.IsDelete = true;
        _unitOfWork.PhoneRepository.Update(phone);
        _unitOfWork.SaveChanges();
    }

    public void UpdatePhone(Phone phone)
    {
        _unitOfWork.PhoneRepository.Update(phone);
        _unitOfWork.SaveChanges();
    }
}
