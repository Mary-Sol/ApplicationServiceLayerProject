namespace ApplicationServiceLayer.ApplicationService.Contracts.ServiceFrameworks
{
    public interface IService <T,TCreate,TDelete, TRead, TUpdate>
    {
        
        
        Task<IEnumerable<TRead>> SelectAll();
        Task<TRead> Select(Guid Id);
        Task Insert(TCreate obj);
        Task Update(TUpdate obj);
        Task Delete(Guid Id);
        Task Delete(TDelete obj);
        Task Save();
    }
}
