using System.Linq.Expressions;
using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Repositories.BaseRepository;

public interface IGenericRepository<T> where T:BaseEntity
{
    Task<T?> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression);
    Task<int> AddAsync(T entity);
    Task<int> AddRangeAsync(IEnumerable<T> entities);
    Task<int> RemoveAsync(T entity);
    Task<int> RemoveRangeAsync(IEnumerable<T> entities);
    Task<int> UpdateAsync(T entity);
}