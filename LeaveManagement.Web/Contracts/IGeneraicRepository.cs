namespace LeaveManagement.Web.Contracts
{
	public interface IGeneraicRepository<T> where T: class
	{
		Task<T> GetAsync(long id);
		Task<List<T>> GetAllAsync();

        Task<T> AddAsync(T entity);
		Task AddARangeAsync(List<T> Entities);

		Task<bool> Exists(long id);
		Task DeleteAsyc(long id);

		Task UpdateAsync(T entity);

		Task<List<T>> GetAllAsync(long id);	
	
	}
}
