using System.Linq.Expressions;
using FarmConnect.Domain;
using Microsoft.EntityFrameworkCore;

namespace FarmConnect.Infrastructure.Repositories.BaseRepository;

public class GenericRepository<T>(DataContext context) : IGenericRepository<T> where T : BaseEntity
{
    public async Task<int> AddAsync(T entity)
    {
        await context.Set<T>().AddAsync(entity);
        return await context.SaveChangesAsync();
    }

    public async Task<int> AddRangeAsync(IEnumerable<T> entities)
    {
        await context.Set<T>().AddRangeAsync(entities);
        return await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression)
    {
        return await context.Set<T>().Where(expression).Where(x=>!x.IsDeleted).ToListAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await context.Set<T>().Where(x=>!x.IsDeleted).ToListAsync();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await context.Set<T>().Where(x=>!x.IsDeleted).FirstOrDefaultAsync(x=>x.Id==id);
    }

    public async Task<int> RemoveAsync(T entity)
    {
        context.Set<T>().Remove(entity);
        return await context.SaveChangesAsync();
    }

    public async Task<int> RemoveRangeAsync(IEnumerable<T> entities)
    {
        context.Set<T>().RemoveRange(entities);
        return await context.SaveChangesAsync();
    }

    public async Task<int> UpdateAsync(T entity)
    {
        context.Set<T>().Update(entity);
        return await context.SaveChangesAsync();
    }}