namespace ApplicationServiceLayer.Models.Services.Contracts.RepositoryFrameworks;

public interface IRepository <T> where T : class
{
    Task<IEnumerable<T>> SelectAll();
    Task<T> SelectById(Guid id);
    Task Insert(T obj);
    Task Delete(T obj);
    Task Update(T obj);
    Task Save();


}
