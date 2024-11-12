using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Repositories.FarmerRepository.FarmerCommandRespository;

public interface IFarmerCommandRepository
{
    Task AddAsync(Farmer farmer);
    Task UpdateAsync(Farmer farmer);
    Task DeleteAsync(int id);
}