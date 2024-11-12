using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Repositories.BuyerRepository.BuyerCommandRepository;

    public interface IBuyerCommandRepository
    {
        Task AddAsync(Buyer buyer);
        Task UpdateAsync(Buyer buyer);
        Task DeleteAsync(int id);
    }
