using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Model.DB;
using System.Repository.IRepository;
using System.Text;

namespace System.Model
{
	[DisplayName("Create new property service")]
	public class PropertyService : BaseModel, IPseudoDeletable
	{
		public bool Delete { get; set; }
	}
}
