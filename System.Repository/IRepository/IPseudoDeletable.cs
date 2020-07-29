using System;
using System.Collections.Generic;
using System.Text;

namespace System.Repository.IRepository
{
	public interface IPseudoDeletable
	{
		/// <summary>
		/// If this property is set to true, the record is marked as deleted. Then the record would not be visible in the listing but may be visible in lookup data.
		/// </summary>
		bool Delete { get; set; }
	}
}
