using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
	public class IGenericRepository<T> : IGeneraicRepository<T> where T : class
	{
		private readonly ApplicationDbContext context;


		public IGenericRepository(ApplicationDbContext context)
		{
			this.context = context;
		}

		

		public async Task<T> AddAsync(T entity)
		{
			await context.AddAsync(entity);
			await context.SaveChangesAsync();

			return entity;

			//throw new NotImplementedException();
		}

		public  async Task DeleteAsyc(long id)
		{
			
			var entity = await GetAsync(id);
			context.Set<T>().Remove(entity);
			await context.SaveChangesAsync();
			//throw new NotImplementedException();
		}

		public async Task<bool> Exists(long id)
		{
			var entity = await GetAsync(id);
			return entity != null;
			
			//throw new NotImplementedException();
		}

		public async Task<List<T>> GetAllAsync()
		{
			return  await context.Set<T>().ToListAsync();
			//throw new NotImplementedException();
		}

		public Task<List<T>> GetAllAsync(long id)
		{
			throw new NotImplementedException();
		}

		public async Task<T> GetAsync(long id)
		{
			
			return await context.Set<T>().FindAsync(id);
			//throw new NotImplementedException();
		}

		public async Task UpdateAsync(T entity)
		{
			//context.Entry(entity).State =  EntityState.Modified;
			context.Update(entity);
			await context.SaveChangesAsync();

			//throw new NotImplementedException();
		}

		//public async Task IGeneraicRepository<T>.AddARangeAsync(List<T> Entities)
		public async Task AddARangeAsync(List<T> Entities)
		{
			await context.AddRangeAsync(Entities);
			await context.SaveChangesAsync();
		}
	}
}
