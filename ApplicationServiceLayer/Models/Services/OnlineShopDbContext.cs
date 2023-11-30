using ApplicationServiceLayer.Models.DomainModels.PersonAggregates;
using ApplicationServiceLayer.Models.DomainModels.ProductAggregates;
using Microsoft.EntityFrameworkCore;

namespace ApplicationServiceLayer.Models.Services;

public class OnlineShopDbContext: DbContext
{
    public DbSet<Product> Product { get; set; }
    public DbSet<Person> Person { get; set; }

    public OnlineShopDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}