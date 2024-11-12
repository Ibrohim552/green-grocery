using FarmConnect.Domain;

namespace FarmConnect.Infrastructure.Services.ProductService;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _unitOfWork.ProductReadRepository.GetAllAsync();
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        return await _unitOfWork.ProductReadRepository.GetByIdAsync(id);
    }

    public async Task CreateProductAsync(Product product)
    {
        await _unitOfWork.ProductCommandRepository.AddAsync(product);
        await _unitOfWork.CompleteAsync();
    }

    public async Task UpdateProductAsync(Product product)
    {
        await _unitOfWork.ProductCommandRepository.UpdateAsync(product);
        await _unitOfWork.CompleteAsync();
    }

    public async Task DeleteProductAsync(int id)
    {
        await _unitOfWork.ProductCommandRepository.DeleteAsync(id);
        await _unitOfWork.CompleteAsync();
    }
}
