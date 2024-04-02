using System.Linq.Expressions;

namespace PersonDirectory.Service.Interface.Repository;

public interface IRepositoryBase<T> where T : class
{
    IEnumerable<T> GetAll();
    T Get(params object[] id);
    IQueryable<T> Set(Expression<Func<T, bool>> predicate);
    IQueryable<T> Set();
    void Insert(T entity);
    void Update(T entity);
    void InsertOrUpdate(T entity);
    void Delete(object id);
    void Delete(T entity);
}
