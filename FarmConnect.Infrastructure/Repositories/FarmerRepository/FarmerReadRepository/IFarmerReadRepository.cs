using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Repositories.FarmerRepository.FarmerReadRepository;

public interface IFarmerReadRepository
{
    Task<Farmer> GetByIdAsync(int id);
    Task<IEnumerable<Farmer>> GetAllAsync();
}