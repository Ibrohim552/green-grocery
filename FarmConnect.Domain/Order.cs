namespace FarmConnect.Domain;

public class Order : BaseEntity
{
    public int BuyerId { get; set; }
    public Buyer Buyer { get; set; } = null!;
    public DateTime OrderDate { get; set; }=DateTime.UtcNow;
    public string? Status { get; set; }
    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
