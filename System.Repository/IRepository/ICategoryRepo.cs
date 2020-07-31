using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Models;
using System.Text;
using System.Threading.Tasks;

namespace System.Repository.IRepository
{
	public interface ICategoryRepo : IAdminRepository<PropertyCategory>
	{
		IEnumerable<SelectListItem> GetCategoryDropDonw();
		Task UpdateAsync(PropertyCategory category);
	}

}
