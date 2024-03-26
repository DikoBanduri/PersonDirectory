using PersonDirectory.DTO;
using PersonDirectory.Service.Interface.IService;
using PersonDirectory.Service.Interface.Repository;

namespace PersonDirectory.Service.Interface;

public sealed class CityService : ICityService
{
    private readonly IUnitOfWork _unitOfWork;

    public CityService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public void CreateCity(City city)
    {
        if (city == null) throw new ArgumentNullException("City is not found");

        _unitOfWork.CityRepository.Insert(city);
        _unitOfWork.SaveChanges();
    }

    public City GetById(int id)
    {
        var city = _unitOfWork.CityRepository.Get(id);
        return city;
    }

    public void DeleteCity(int cityId)
    {
        var city = _unitOfWork.CityRepository.Get(cityId);
        city.IsDelete = true;
        _unitOfWork.CityRepository.Update(city);
        _unitOfWork.SaveChanges();
    }

    public void UpdateCity(City city)
    {
        _unitOfWork.CityRepository.Update(city);
        _unitOfWork.SaveChanges();
    }
}
