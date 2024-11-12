namespace FarmConnect.Application.Filter;

public record OrderFilter
{
    public int BuyerId { get; set; }
    public DateTime OrderDate { get; set; }
}