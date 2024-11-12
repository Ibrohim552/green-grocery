using FarmConnect.Domain;
using Microsoft.EntityFrameworkCore;

namespace FarmConnect.Infrastructure.Repositories.BuyerRepository.BuyerReadRepository;

public class BuyerReadRepository : IBuyerReadRepository
{
    private readonly DataContext _context;

    public BuyerReadRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<Buyer> GetByIdAsync(int id)
    {
        return await _context.Buyers.FindAsync(id);
    }

    public async Task<IEnumerable<Buyer>> GetAllAsync()
    {
        return await _context.Buyers.ToListAsync();
    }
}