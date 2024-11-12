using FarmConnect.Domain;
using Microsoft.EntityFrameworkCore;

namespace FarmConnect.Infrastructure.Repositories.BuyerRepository.BuyerCommandRepository;

public class BuyerCommandRepository : IBuyerCommandRepository
{
    private readonly DataContext _context;

    public BuyerCommandRepository(DataContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Buyer buyer)
    {
        await _context.Buyers.AddAsync(buyer);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Buyer buyer)
    {
        _context.Buyers.Update(buyer);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var buyer = await _context.Buyers.FindAsync(id);
        if (buyer != null)
        {
            _context.Buyers.Remove(buyer);
            await _context.SaveChangesAsync();
        }
    }
}