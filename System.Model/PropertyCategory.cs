using System;
using System.Collections.Generic;
using System.Model.DB;
using System.Text;

namespace System.Model
{
	public class PropertyCategory : BaseModel
	{
		public string Name { get; set; }
		public int DisplayOrder { get; set; }
	}
}
