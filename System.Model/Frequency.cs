using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Model.DB;
using System.Text;

namespace System.Model
{
	public class Frequency : BaseModel
	{
		[Required]
		public int FrequencyCount { get; set; }

		[Required]
		[Display(Name = "Frequency Name")]
		public string Name { get; set; }
	}
}
