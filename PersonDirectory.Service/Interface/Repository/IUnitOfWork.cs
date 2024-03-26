namespace PersonDirectory.Service.Interface.Repository;

public interface IUnitOfWork : IDisposable
{
    ICityRepository CityRepository { get;}
    IPersonRepository PersonRepository { get;}
    IPhoneRepository PhoneRepository { get;}
    IRelationRepository RelationRepository { get;}
    int SaveChanges();
    void BeginTransaction();
    void CommitTransaction();
    void RollBack();
}
