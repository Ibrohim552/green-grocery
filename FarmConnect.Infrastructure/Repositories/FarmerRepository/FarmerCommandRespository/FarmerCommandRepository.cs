using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Repositories.FarmerRepository.FarmerCommandRespository;

public class FarmerCommandRepository : IFarmerCommandRepository
{
    private readonly DataContext _context;

    public FarmerCommandRepository(DataContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Farmer farmer)
    {
        await _context.Farmers.AddAsync(farmer);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Farmer farmer)
    {
        _context.Farmers.Update(farmer);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var farmer = await _context.Farmers.FindAsync(id);
        if (farmer != null)
        {
            _context.Farmers.Remove(farmer);
            await _context.SaveChangesAsync();
        }
    }
}
