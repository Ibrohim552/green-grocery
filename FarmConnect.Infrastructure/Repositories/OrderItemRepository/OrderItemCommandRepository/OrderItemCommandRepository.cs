using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Repositories.OrderItemRepository.OrderItemCommandRepository;

public class OrderItemCommandRepository : IOrderItemCommandRepository
{
    private readonly DataContext _context;

    public OrderItemCommandRepository(DataContext context)
    {
        _context = context;
    }

    public async Task AddAsync(OrderItem orderItem)
    {
        await _context.OrderItems.AddAsync(orderItem);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(OrderItem orderItem)
    {
        _context.OrderItems.Update(orderItem);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var orderItem = await _context.OrderItems.FindAsync(id);
        if (orderItem != null)
        {
            _context.OrderItems.Remove(orderItem);
            await _context.SaveChangesAsync();
        }
    }
}
