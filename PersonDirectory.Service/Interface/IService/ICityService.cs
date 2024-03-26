using PersonDirectory.DTO;

namespace PersonDirectory.Service.Interface.IService;

public interface ICityService 
{
    void CreateCity(City city);
    void UpdateCity(City city);
    void DeleteCity(int cityId);
}
