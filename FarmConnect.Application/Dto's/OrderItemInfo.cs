using FluentValidation;

namespace FarmConnect.Application.Dto_s;

public record OrderItemBaseInfo(int ProductId, int Quantity);

public record OrderItemReadInfo(int Id, OrderItemBaseInfo BaseInfo);
public record OrderItemCreateInfo(OrderItemBaseInfo BaseInfo);
public record OrderItemUpdateInfo(int Id, OrderItemBaseInfo BaseInfo);

public class OrderItemValidator : AbstractValidator<OrderItemBaseInfo>
{
    public OrderItemValidator()
    {
        RuleFor(x => x.ProductId)
            .GreaterThan(0).WithMessage("Product ID must be greater than zero");
        RuleFor(x => x.Quantity)
            .GreaterThan(0).WithMessage("Quantity must be greater than zero");
        RuleFor(x => x.Quantity)
            .LessThanOrEqualTo(999).WithMessage("Quantity must not exceed 999");
    }
}