using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Repositories.ProductRepository.ProductReadRepository;

public interface IProductReadRepository
{
    Task<Product> GetByIdAsync(int id);
    Task<IEnumerable<Product>> GetAllAsync();
    Task<IEnumerable<Product>> GetByCategoryAsync(int categoryId);
}