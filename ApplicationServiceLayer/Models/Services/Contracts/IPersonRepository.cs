using ApplicationServiceLayer.Models.DomainModels.PersonAggregates;
using ApplicationServiceLayer.Models.Services.Contracts.RepositoryFrameworks;

namespace ApplicationServiceLayer.Models.Services.Contracts;

public interface IPersonRepository : IRepository<Person>
{
}
