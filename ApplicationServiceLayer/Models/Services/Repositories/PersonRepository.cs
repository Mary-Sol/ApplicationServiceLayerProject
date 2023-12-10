using ApplicationServiceLayer.Models.DomainModels.PersonAggregates;
using ApplicationServiceLayer.Models.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ApplicationServiceLayer.Models.Services.Reporitories;

public class PersonRepository : IPersonRepository
{
    private readonly OnlineShopDbContext _dbContext;

    public PersonRepository(OnlineShopDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Delete(Person person)
    {
        try
        {
            _dbContext.Person.Remove(person);
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
            var deletedPerson = await _dbContext.Person.FindAsync(id);
            if (deletedPerson is not null)
            {
                _dbContext.Person.Remove(deletedPerson);

            }
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

    public async Task<IEnumerable<Person>> SelectAll()
    {
        try
        {
            return await _dbContext.Person.ToListAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<Person> SelectById(Guid id)
    {
        try
        {
            return await _dbContext.Person.FindAsync(id);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public async Task Insert( Person person)
    {
        try
        {
            return await _dbContext.Person.CreateDbCommand()
        }

    }

    public async Task Update(Person person)
    {
        try
        {
            if (person is not null)
            {
                _dbContext.Entry(person).State = EntityState.Modified;
            }

        }
        catch (Exception)
        {
            throw;
        }
    }
}












