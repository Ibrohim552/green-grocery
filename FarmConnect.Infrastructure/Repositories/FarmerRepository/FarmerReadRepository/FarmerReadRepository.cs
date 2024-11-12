using FarmConnect.Domain;
using Microsoft.EntityFrameworkCore;

namespace FarmConnect.Infrastructure.Repositories.FarmerRepository.FarmerReadRepository;

public class FarmerReadRepository : IFarmerReadRepository
{
    private readonly DataContext _context;

    public FarmerReadRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<Farmer> GetByIdAsync(int id) => await _context.Farmers.FindAsync(id);

    public async Task<IEnumerable<Farmer>> GetAllAsync() => await _context.Farmers.ToListAsync();
}
