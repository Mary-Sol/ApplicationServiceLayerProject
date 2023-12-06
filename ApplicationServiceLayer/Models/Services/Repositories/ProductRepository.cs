using ApplicationServiceLayer.Models.DomainModels.PersonAggregates;
using ApplicationServiceLayer.Models.DomainModels.ProductAggregates;
using ApplicationServiceLayer.Models.Services.Contracts;
using ApplicationServiceLayer.Models.Services.Contracts.RepositoryFrameworks;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApplicationServiceLayer.Models.Services.Reporitories;

public class ProductRepository : IProductRepository
{
    private readonly OnlineShopDbContext _dbContext;

    public ProductRepository(OnlineShopDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Delete(Product product)
    {
        try
        {
            _dbContext.Product.Remove(product);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task Delete(Guid id)
    {
        try
        {
            var deletedProduct = await _dbContext.Product.FindAsync(id);
            if (deletedProduct is not null)
            {
                _dbContext.Product.Remove(deletedProduct);

            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<Product> GetByProductcodeAsync(string ProductCode)
   {
        try
        {
            return await _dbContext.Product.FirstOrDefaultAsync(p => p.ProductCode == ProductCode);
        }
        catch (Exception)
        {
            throw;
        }

    }

    public async Task Save()
    {
        try
        {
            await _dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<IEnumerable<Product>> SelectAll()
    {
        try
        {
            return await _dbContext.Product.ToListAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<Product> SelectById(Guid id)
    {
        try
        {
            return await _dbContext.Product.FindAsync(id);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task Update(Product product)
    {

        try
        {
            if (product is not null)
            {
                _dbContext.Entry(product).State = EntityState.Modified;
            }

        }
        catch (Exception)
        {
            throw;
        }
    }
}

