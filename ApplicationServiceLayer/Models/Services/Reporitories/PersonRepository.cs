using ApplicationServiceLayer.Models.DomainModels.PersonAggregates;
using ApplicationServiceLayer.Models.Services.Contracts;

namespace ApplicationServiceLayer.Models.Services.Reporitories;

public class PersonRepository : IPersonRepository
{
    private readonly OnlineShopDbContext _dbContext;

    public PersonRepository(OnlineShopDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task Delete(Person obj)
    {
        throw new NotImplementedException();
    }

    public Task Insert(Person obj)
    {
        throw new NotImplementedException();
    }

    public Task Save()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Person>> SelectAll()
    {
        throw new NotImplementedException();
    }

    public Task<Person> SelectById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task Update(Person obj)
    {
        throw new NotImplementedException();
    }
}
