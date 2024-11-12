using FluentValidation;

namespace FarmConnect.Application.Dto_s;

public record ProductBaseInfo(string? Name, string? Description, decimal Price, int QuantityAvailable);

public record ProductReadInfo(int Id, ProductBaseInfo BaseInfo, int FarmerId);

public record ProductCreateInfo(ProductBaseInfo BaseInfo, int FarmerId);

public record ProductUpdateInfo(int Id, ProductBaseInfo BaseInfo, int FarmerId);

public class ProductBaseValidator : AbstractValidator<ProductBaseInfo>
{
    public ProductBaseValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is necessarily").MaximumLength(255)
            .WithMessage("Name must not exceed 255 characters");
        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Description is necessarily")
            .MaximumLength(255).WithMessage("Description must not exceed 255 characters");
        RuleFor(x => x.Price)
            .GreaterThan(0).WithMessage("Price must be greater than zero");
        RuleFor(x => x.QuantityAvailable)
            .GreaterThan(0).WithMessage("Quantity available must be greater than zero");
    }
}