using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Repository.IRepository;
using System.Text;

namespace System.Model.DB
{
	public class BaseModel : IDBModel
	{
		[Key]
		public virtual Guid Id { get; set; }
		public virtual DateTime CreateDate { get; set; }
	}
}
