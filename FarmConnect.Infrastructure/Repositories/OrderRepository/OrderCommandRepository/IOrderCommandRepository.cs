using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Repositories.OrderRepository.OrderCommandRepository;

public interface IOrderCommandRepository
{
    Task AddAsync(Order order);
    Task UpdateAsync(Order order);
    Task DeleteAsync(int id);
}