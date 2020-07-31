using System;
using System.Collections.Generic;
using System.Text;

namespace System.Models
{
	public interface IDBModel
	{
		public Guid Id { get; set; }
		public DateTime	CreateDate { get; set; }
	}
}
