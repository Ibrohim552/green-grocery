using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Services.OrderService;

public class OrderService : IOrderService
{
    private readonly IUnitOfWork _unitOfWork;

    public OrderService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Order>> GetAllOrdersAsync()
    {
        return await _unitOfWork.OrderReadRepository.GetAllAsync();
    }

    public async Task<Order> GetOrderByIdAsync(int id)
    {
        return await _unitOfWork.OrderReadRepository.GetByIdAsync(id);
    }

    public async Task CreateOrderAsync(Order order)
    {
        await _unitOfWork.OrderCommandRepository.AddAsync(order);
        await _unitOfWork.CompleteAsync();
    }

    public async Task UpdateOrderAsync(Order order)
    {
        await _unitOfWork.OrderCommandRepository.UpdateAsync(order);
        await _unitOfWork.CompleteAsync();
    }

    public async Task DeleteOrderAsync(int id)
    {
        await _unitOfWork.OrderCommandRepository.DeleteAsync(id);
        await _unitOfWork.CompleteAsync();
    }
}
