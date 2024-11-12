using FarmConnect.Infrastructure;
using FarmConnect.Infrastructure.Repositories.BuyerRepository.BuyerCommandRepository;
using FarmConnect.Infrastructure.Repositories.BuyerRepository.BuyerReadRepository;
using FarmConnect.Infrastructure.Repositories.FarmerRepository.FarmerCommandRespository;
using FarmConnect.Infrastructure.Repositories.FarmerRepository.FarmerReadRepository;
using FarmConnect.Infrastructure.Repositories.OrderItemRepository.OrderItemCommandRepository;
using FarmConnect.Infrastructure.Repositories.OrderItemRepository.OrderItemReadRepository;
using FarmConnect.Infrastructure.Repositories.OrderRepository.OrderCommandRepository;
using FarmConnect.Infrastructure.Repositories.OrderRepository.OrderReadRepository;
using FarmConnect.Infrastructure.Repositories.ProductRepository.ProductCommandRepository;
using FarmConnect.Infrastructure.Repositories.ProductRepository.ProductReadRepository;

public class UnitOfWork : IUnitOfWork
{
    private readonly DataContext _context;

    public UnitOfWork(DataContext context)
    {
        _context = context;
        BuyerReadRepository = new BuyerReadRepository(_context);
        BuyerCommandRepository = new BuyerCommandRepository(_context);

        FarmerReadRepository = new FarmerReadRepository(_context);
        FarmerCommandRepository = new FarmerCommandRepository(_context);

        ProductReadRepository = new ProductReadRepository(_context);
        ProductCommandRepository = new ProductCommandRepository(_context);

        OrderReadRepository = new OrderReadRepository(_context);
        OrderCommandRepository = new OrderCommandRepository(_context);

        OrderItemReadRepository = new OrderItemReadRepository(_context);
        OrderItemCommandRepository = new OrderItemCommandRepository(_context);
    }

    public IBuyerReadRepository BuyerReadRepository { get; }
    public IBuyerCommandRepository BuyerCommandRepository { get; }

    public IFarmerReadRepository FarmerReadRepository { get; }
    public IFarmerCommandRepository FarmerCommandRepository { get; }

    public IProductReadRepository ProductReadRepository { get; }
    public IProductCommandRepository ProductCommandRepository { get; }

    public IOrderReadRepository OrderReadRepository { get; }
    public IOrderCommandRepository OrderCommandRepository { get; }

    public IOrderItemReadRepository OrderItemReadRepository { get; }
    public IOrderItemCommandRepository OrderItemCommandRepository { get; }

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}