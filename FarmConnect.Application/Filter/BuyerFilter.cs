namespace FarmConnect.Application.Filter;

public record BuyerFilter: BaseFilter
{
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
    public string Email { get; set; }
}