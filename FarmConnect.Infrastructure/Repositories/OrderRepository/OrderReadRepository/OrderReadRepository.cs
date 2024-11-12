using FarmConnect.Domain;
using Microsoft.EntityFrameworkCore;

namespace FarmConnect.Infrastructure.Repositories.OrderRepository.OrderReadRepository;

public class OrderReadRepository : IOrderReadRepository
{
    private readonly DataContext _context;

    public OrderReadRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<Order> GetByIdAsync(int id) => await _context.Orders.FindAsync(id);

    public async Task<IEnumerable<Order>> GetAllAsync() => await _context.Orders.ToListAsync();

    public async Task<IEnumerable<Order>> GetByCustomerIdAsync(int customerId)
    {
        return await _context.Orders.Where(x => x.Id == customerId).ToListAsync();
    }
}
