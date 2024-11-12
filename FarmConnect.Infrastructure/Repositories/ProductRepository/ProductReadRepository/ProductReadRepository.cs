using FarmConnect.Domain;
using Microsoft.EntityFrameworkCore;

namespace FarmConnect.Infrastructure.Repositories.ProductRepository.ProductReadRepository;

public class ProductReadRepository : IProductReadRepository
{
    private readonly DataContext _context;

    public ProductReadRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<Product> GetByIdAsync(int id) => await _context.Products.FindAsync(id);

    public async Task<IEnumerable<Product>> GetAllAsync() => await _context.Products.ToListAsync();

    public async Task<IEnumerable<Product>> GetByCategoryAsync(int categoryId)
    {
        return await _context.Products.Where(x => x.Id == categoryId).ToListAsync();
    }
}
