using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Repository.IRepository;
using System.Text;
using System.Threading.Tasks;

namespace System.Repository.Repository
{
	public class AdminRepository<TDModel> : IAdminRepository<TDModel> where TDModel : class
	{
		private readonly DbContext dbContext;
		protected internal DbSet<TDModel> dbSet;

		public AdminRepository(DbContext dbContext)
		{
			this.dbContext = dbContext;
			dbSet = dbContext.Set<TDModel>();
		}
		public async Task AddAsync(TDModel entity)
		{
			await dbSet.AddAsync(entity);
		}

		public TDModel Get(int id)
		{
			return dbSet.Find(id);
		}

		public TDModel Get(Guid id)
		{
			return dbSet.Find(id);
		}

		public IEnumerable<TDModel> GetAll(Expression<Func<TDModel, bool>> filter = null, Func<IQueryable<TDModel>, IOrderedQueryable<TDModel>> orderBy = null, string includeProperties = null)
		{
			IQueryable<TDModel> query = null;
			if (filter != null)
				query.Where(filter);
			if (includeProperties != null)
				foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
					query.Include(includeProperty);
			if (orderBy != null)
				return orderBy(query).ToList();
			return query.ToList();
		}

		public TDModel GetFirstOrDefault(Expression<Func<TDModel, bool>> filter = null, string includeProperties = null)
		{
			IQueryable<TDModel> query = null;
			if (filter != null)
				query.Where(filter);
			if (includeProperties != null)
				foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
					query.Include(includeProperty);
			return query.FirstOrDefault();
		}

		public void Remove(int id)
		{
			var removeById = dbSet.Find(id);
			dbSet.Remove(removeById);
		}

		public void Remove(Guid id)
		{
			var removeByGuid = dbSet.Find(id);
			dbSet.Remove(removeByGuid);
		}

		public void Remove(TDModel entity)
		{
			dbSet.Remove(entity);
		}
	}
}
