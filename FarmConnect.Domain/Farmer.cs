namespace FarmConnect.Domain;

public class Farmer : BaseEntity
{
    public string? Name { get; set; }
    public string? Location { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();
}