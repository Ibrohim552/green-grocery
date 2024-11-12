using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Services.OrderItemService;

public interface IOrderItemService
{
    Task<IEnumerable<OrderItem>> GetAllOrderItemsAsync();
    Task<OrderItem> GetOrderItemByIdAsync(int id);
    Task CreateOrderItemAsync(OrderItem orderItem);
    Task UpdateOrderItemAsync(OrderItem orderItem);
    Task DeleteOrderItemAsync(int id);
}
