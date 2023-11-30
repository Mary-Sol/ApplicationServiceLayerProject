using ApplicationServiceLayer.Models.DomainModels.ProductAggregates;
using ApplicationServiceLayer.Models.Services.Contracts.RepositoryFrameworks;

namespace ApplicationServiceLayer.Models.Services.Contracts;

public interface IProductRepository : IRepository<Product>
{
}
