using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Repositories.OrderItemRepository.OrderItemCommandRepository;

public interface IOrderItemCommandRepository
{
    Task AddAsync(OrderItem orderItem);
    Task UpdateAsync(OrderItem orderItem);
    Task DeleteAsync(int id);
}