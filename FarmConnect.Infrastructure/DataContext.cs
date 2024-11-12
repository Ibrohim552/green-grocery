using FarmConnect.Domain;
using Microsoft.EntityFrameworkCore;

namespace FarmConnect.Infrastructure;

public class DataContext(DbContextOptions<DataContext> options):DbContext(options)
{
    public DbSet<Farmer> Farmers{ get;  set;}
    public DbSet<Buyer> Buyers{ get;  set;}
    public DbSet<Product> Products{ get;  set;}
    public DbSet<Order> Orders{ get;  set;}
    public DbSet<OrderItem> OrderItems{ get;  set;}
    

}