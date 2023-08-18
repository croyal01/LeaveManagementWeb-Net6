using LeaveManagement.Data;

namespace LeaveManagement.Application.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(long? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(List<T> entities);
        Task<bool> Exists(long id);
        Task DeleteAsync(long id);
        Task UpdateAsync(T entity);
    }
}
