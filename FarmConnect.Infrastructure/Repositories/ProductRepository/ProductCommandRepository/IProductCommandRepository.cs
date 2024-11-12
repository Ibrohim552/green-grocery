using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Repositories.ProductRepository.ProductCommandRepository;

public interface IProductCommandRepository
{
    Task AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(int id);
}