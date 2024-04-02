using System.Linq.Expressions;

namespace PersonDirectory.Service.Interface.Repository;

public interface IRepositoryBase<T> where T : class
{
    T Get(params object[] id);
    T Get(Expression<Func<T, bool>> expression);
    IEnumerable<T> GetAll();
    IEnumerable<T> GetAll(Expression<Func<T, bool>> expression);
    void Insert(T entity);
    void Update(T entity);
    void InsertOrUpdate(T entity);
    void Delete(object id);
    void Delete(T entity);

    Task<T> GetAsync(params object[] id);

    //Task<T> GetAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
}
