using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Services.OrderItemService;

public class OrderItemService : IOrderItemService
{
    private readonly IUnitOfWork _unitOfWork;

    public OrderItemService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<OrderItem>> GetAllOrderItemsAsync()
    {
        return await _unitOfWork.OrderItemReadRepository.GetAllAsync();
    }

    public async Task<OrderItem> GetOrderItemByIdAsync(int id)
    {
        return await _unitOfWork.OrderItemReadRepository.GetByIdAsync(id);
    }

    public async Task CreateOrderItemAsync(OrderItem orderItem)
    {
        await _unitOfWork.OrderItemCommandRepository.AddAsync(orderItem);
        await _unitOfWork.CompleteAsync();
    }

    public async Task UpdateOrderItemAsync(OrderItem orderItem)
    {
        await _unitOfWork.OrderItemCommandRepository.UpdateAsync(orderItem);
        await _unitOfWork.CompleteAsync();
    }

    public async Task DeleteOrderItemAsync(int id)
    {
        await _unitOfWork.OrderItemCommandRepository.DeleteAsync(id);
        await _unitOfWork.CompleteAsync();
    }
}
