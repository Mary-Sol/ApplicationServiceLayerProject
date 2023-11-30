using ApplicationServiceLayer.Models.DomainModels.ProductAggregates;
using ApplicationServiceLayer.Models.Services.Contracts;

namespace ApplicationServiceLayer.Models.Services.Reporitories;

public class ProductRepository : IProductRepository
{
    private readonly OnlineShopDbContext _dbContext;

    public ProductRepository(OnlineShopDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task Delete(Product obj)
    {
        throw new NotImplementedException();
    }

    public Task Insert(Product obj)
    {
        throw new NotImplementedException();
    }

    public Task Save()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> SelectAll()
    {
        throw new NotImplementedException();
    }

    public Task<Product> SelectById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task Update(Product obj)
    {
        throw new NotImplementedException();
    }
}
