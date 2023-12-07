using ApplicationServiceLayer.ApplicationService.Contracts.ServiceFrameworks;
using ApplicationServiceLayer.ApplicationService.Dtos.ProductDtos;
using ApplicationServiceLayer.Models.DomainModels.ProductAggregates;

namespace ApplicationServiceLayer.ApplicationService.Contracts
{
    public interface IProductService : IService<Product, DeleteProductDtos, UpdateProductDtos, SelectProductDtos, CreateProductDtos>
    {
        Task<SelectProductDtos> Select(string productCode);
    }
}
