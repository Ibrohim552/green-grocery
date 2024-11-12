using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Services.BuyerService;

public class BuyerService : IBuyerService
{
    private readonly IUnitOfWork _unitOfWork;

    public BuyerService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Buyer>> GetAllBuyersAsync()
    {
        return await _unitOfWork.BuyerReadRepository.GetAllAsync();
    }

    public async Task<Buyer> GetBuyerByIdAsync(int id)
    {
        return await _unitOfWork.BuyerReadRepository.GetByIdAsync(id);
    }

    public async Task CreateBuyerAsync(Buyer buyer)
    {
        await _unitOfWork.BuyerCommandRepository.AddAsync(buyer);
        await _unitOfWork.CompleteAsync();
    }

    public async Task UpdateBuyerAsync(Buyer buyer)
    {
        await _unitOfWork.BuyerCommandRepository.UpdateAsync(buyer);
        await _unitOfWork.CompleteAsync();
    }

    public async Task DeleteBuyerAsync(int id)
    {
        await _unitOfWork.BuyerCommandRepository.DeleteAsync(id);
        await _unitOfWork.CompleteAsync();
    }
}
