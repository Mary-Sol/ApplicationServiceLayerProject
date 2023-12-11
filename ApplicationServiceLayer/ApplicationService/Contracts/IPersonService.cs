using ApplicationServiceLayer.ApplicationService.Contracts.ServiceFrameworks;
using ApplicationServiceLayer.ApplicationService.Dtos.PersonDtos;
using ApplicationServiceLayer.Models.DomainModels.PersonAggregates;

namespace ApplicationServiceLayer.ApplicationService.Contracts;

public interface IPersonService : IService<Person, CreatePersonDtos, DeletePersonDtos, UpdatePersonDtos, SelectPersonDtos>
{
    
}
