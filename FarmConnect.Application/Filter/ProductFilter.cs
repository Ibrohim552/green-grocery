namespace FarmConnect.Application.Filter;

public record ProductFilter
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal  Price { get; set; }
    public int QuantityAvailable { get; set; }
    public int FarmerId { get; set; }
}