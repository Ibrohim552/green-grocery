using FarmConnect.Domain;
using Microsoft.EntityFrameworkCore;

namespace FarmConnect.Infrastructure.Repositories.OrderItemRepository.OrderItemReadRepository;

public class OrderItemReadRepository : IOrderItemReadRepository
{
    private readonly DataContext _context;

    public OrderItemReadRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<OrderItem> GetByIdAsync(int id) => await _context.OrderItems.FindAsync(id);

    public async Task<IEnumerable<OrderItem>> GetAllAsync() => await _context.OrderItems.ToListAsync();

    public async Task<IEnumerable<OrderItem>> GetByOrderIdAsync(int orderId)
    {
        return await _context.OrderItems.Where(x => x.OrderId == orderId).ToListAsync();
    }
}
