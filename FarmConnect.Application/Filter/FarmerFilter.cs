namespace FarmConnect.Application.Filter;

public record FarmerFilter:BaseFilter
{
    public string?   Name { get; set; }
    public string?   PhoneNumber { get; set; }
    public string?   Email { get; set; }
    public string Location { get; set; }
}