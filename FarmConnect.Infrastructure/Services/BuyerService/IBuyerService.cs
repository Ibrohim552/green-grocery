using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Services.BuyerService;

public interface IBuyerService
{
    Task<IEnumerable<Buyer>> GetAllBuyersAsync();
    Task<Buyer> GetBuyerByIdAsync(int id);
    Task CreateBuyerAsync(Buyer buyer);
    Task UpdateBuyerAsync(Buyer buyer);
    Task DeleteBuyerAsync(int id);
}