using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace System.Repository.IRepository
{
	public interface IUnitOfWork
	{
		ICategoryRepo CategoryWork { get;}
		Task SaveAsync();
	}
}
