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

public interface IUnitOfWork
{
    IBuyerReadRepository BuyerReadRepository { get; }
    IBuyerCommandRepository BuyerCommandRepository { get; }
    
    IFarmerReadRepository FarmerReadRepository { get; }
    IFarmerCommandRepository FarmerCommandRepository { get; }
    
    IProductReadRepository ProductReadRepository { get; }
    IProductCommandRepository ProductCommandRepository { get; }
    
    IOrderReadRepository OrderReadRepository { get; }
    IOrderCommandRepository OrderCommandRepository { get; }

    IOrderItemReadRepository OrderItemReadRepository { get; }
    IOrderItemCommandRepository OrderItemCommandRepository { get; }
    
    Task CompleteAsync();
}
