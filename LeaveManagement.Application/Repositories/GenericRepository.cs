using LeaveManagement.Application.Contracts;
using LeaveManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Application.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly ApplicationDbContext context;


		public GenericRepository(ApplicationDbContext context)
		{
			this.context = context;
		}



		public async Task<T> AddAsync(T entity)
		{
			await context.AddAsync(entity);
			await context.SaveChangesAsync();

			return entity;


		}

		public async Task DeleteAsyc(long id)
		{
			var entity = await GetAsync(id);
			context.Set<T>().Remove(entity);
			await context.SaveChangesAsync();

		}

		public async Task<bool> Exists(long id)
		{
			var entity = await GetAsync(id);
			return entity != null;

			//throw new NotImplementedException();
		}

		public async Task<List<T>> GetAllAsync()
		{
			return await context.Set<T>().ToListAsync();
		}

		public async Task<T> GetAsync(long? id)
		{
			return await context.Set<T>().FindAsync(id);
		}

		public async Task UpdateAsync(T entity)
		{
			context.Update(entity);
			await context.SaveChangesAsync();
		}

		

		public async Task  AddRangeAsync(List<T> entities)
		{
			await context.AddRangeAsync(entities);
			await context.SaveChangesAsync();
		}

		public async Task DeleteAsync(long id)
		{
			var entity = await GetAsync(id);
			context.Set<T>().Remove(entity);
			await context.SaveChangesAsync();

		}
	}
}
