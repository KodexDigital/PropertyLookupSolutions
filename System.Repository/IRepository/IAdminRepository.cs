using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace System.Repository.IRepository
{
	public interface IAdminRepository<TDBModel> where TDBModel:class
	{
		TDBModel Get(int id);
		TDBModel Get(Guid id);

		IEnumerable<TDBModel> GetAll(
			Expression<Func<TDBModel, bool>> filter = null, 
			Func<IQueryable<TDBModel>, IOrderedQueryable<TDBModel>> orderBy = null, 
			string includeProperties = null
			);

		TDBModel GetFirstOrDefault(Expression<Func<TDBModel, bool>> filter = null,
			string includeProperties = null);

		Task AddAsync(TDBModel entity);
		void Remove(int id);
		void Remove(Guid id);
		void Remove(TDBModel entity);
	}
}
