using PersonDirectory.DTO;

namespace PersonDirectory.Service.Interface.IService;

public interface IPhoneService
{
    void CreatePhone (Phone phone);
    void UpdatePhone (Phone phone); 
    void DeletePhone (int phoneId);
}
