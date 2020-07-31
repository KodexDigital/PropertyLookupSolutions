using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Models;
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
