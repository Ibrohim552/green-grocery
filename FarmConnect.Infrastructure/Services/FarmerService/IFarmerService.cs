using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Services.FarmerService;

public interface IFarmerService
{
    Task<IEnumerable<Farmer>> GetAllFarmersAsync();
    Task<Farmer> GetFarmerByIdAsync(int id);
    Task CreateFarmerAsync(Farmer farmer);
    Task UpdateFarmerAsync(Farmer farmer);
    Task DeleteFarmerAsync(int id);
}
