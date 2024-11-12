using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Services.FarmerService;

public class FarmerService : IFarmerService
{
    private readonly IUnitOfWork _unitOfWork;

    public FarmerService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Farmer>> GetAllFarmersAsync()
    {
        return await _unitOfWork.FarmerReadRepository.GetAllAsync();
    }

    public async Task<Farmer> GetFarmerByIdAsync(int id)
    {
        return await _unitOfWork.FarmerReadRepository.GetByIdAsync(id);
    }

    public async Task CreateFarmerAsync(Farmer farmer)
    {
        await _unitOfWork.FarmerCommandRepository.AddAsync(farmer);
        await _unitOfWork.CompleteAsync();
    }

    public async Task UpdateFarmerAsync(Farmer farmer)
    {
        await _unitOfWork.FarmerCommandRepository.UpdateAsync(farmer);
        await _unitOfWork.CompleteAsync();
    }

    public async Task DeleteFarmerAsync(int id)
    {
        await _unitOfWork.FarmerCommandRepository.DeleteAsync(id);
        await _unitOfWork.CompleteAsync();
    }
}
