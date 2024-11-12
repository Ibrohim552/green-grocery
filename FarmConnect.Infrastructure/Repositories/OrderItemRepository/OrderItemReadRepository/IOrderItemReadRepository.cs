using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Repositories.OrderItemRepository.OrderItemReadRepository;

public interface IOrderItemReadRepository
{
    Task<OrderItem> GetByIdAsync(int id);
    Task<IEnumerable<OrderItem>> GetAllAsync();
    Task<IEnumerable<OrderItem>> GetByOrderIdAsync(int orderId);
}