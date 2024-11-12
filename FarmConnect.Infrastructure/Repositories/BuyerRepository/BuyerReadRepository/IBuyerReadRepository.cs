using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Repositories.BuyerRepository.BuyerReadRepository;

public interface IBuyerReadRepository
{
    Task<Buyer> GetByIdAsync(int id);
    Task<IEnumerable<Buyer>> GetAllAsync();
}