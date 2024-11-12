using FluentValidation;

namespace FarmConnect.Application.Dto_s;

public record OrderBaseInfo(DateTime OrderDate, string? Status);

public record OrderReadInfo(int Id, OrderBaseInfo BaseInfo, int BuyerId, List<OrderItemReadInfo> OrderItems);

public record OrderCreateInfo(OrderBaseInfo BaseInfo, int BuyerId, List<OrderItemCreateInfo> OrderItems);

public record OrderUpdateInfo(int Id, OrderBaseInfo BaseInfo, int BuyerId, List<OrderItemUpdateInfo> OrderItems);



public class OrderBaseValidator : AbstractValidator<OrderBaseInfo>
{
    public OrderBaseValidator()
    {
        RuleFor(x => x.OrderDate)
            .NotEmpty().WithMessage("Order date is necessarily");
        RuleFor(x => x.Status)
            .NotEmpty().WithMessage("Status is necessarily");
        RuleFor(x => x.Status)
            .Must(status => status == "Pending" || status == "Completed" || status == "Cancelled")
            .WithMessage("Status must be either 'Pending', 'Completed', or 'Cancelled'");
    }
}