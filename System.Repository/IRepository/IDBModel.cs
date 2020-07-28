using System;
using System.Collections.Generic;
using System.Text;

namespace System.Repository.IRepository
{
	public interface IDBModel
	{
		public Guid Id { get; set; }
		public DateTime	CreateDate { get; set; }
	}
}
