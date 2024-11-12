using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Repositories.OrderRepository.OrderReadRepository;

public interface IOrderReadRepository
{
    Task<Order> GetByIdAsync(int id);
    Task<IEnumerable<Order>> GetAllAsync();
    Task<IEnumerable<Order>> GetByCustomerIdAsync(int customerId);
}