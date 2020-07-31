using System;
using System.Collections.Generic;
using System.DAL.Data;
using System.Repository.IRepository;
using System.Text;
using System.Threading.Tasks;

namespace System.Repository.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDbContext dbContext;

		public UnitOfWork(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
			CategoryWork = new CategoryRepo(dbContext);
		}
		public ICategoryRepo CategoryWork { get; private set; }

		public async Task SaveAsync()
		{
			await dbContext.SaveChangesAsync();
		}
	}
}
