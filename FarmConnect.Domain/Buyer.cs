namespace FarmConnect.Domain;

public class Buyer : BaseEntity
{
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public List<Order> Orders { get; set; } = new List<Order>(); 
}
