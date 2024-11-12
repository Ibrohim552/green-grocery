namespace FarmConnect.Domain;

public class Product : BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int QuantityAvailable { get; set; }
    public int FarmerId { get; set; }
    public Farmer Farmer { get; set; } = null!;
    public List<OrderItem> OrderItems { get; set; } = new();

}