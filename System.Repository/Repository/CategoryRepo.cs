using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.DAL.Data;
using System.Linq;
using System.Models;
using System.Repository.IRepository;
using System.Text;
using System.Threading.Tasks;

namespace System.Repository.Repository
{
	public class CategoryRepo : AdminRepository<PropertyCategory>, ICategoryRepo
	{
		private readonly ApplicationDbContext context;

		public CategoryRepo(ApplicationDbContext context) : base(context)
		{
			this.context = context;
		}
		public IEnumerable<SelectListItem> GetCategoryDropDonw()
		{
			return context.PropertyCategories.Select(c => new SelectListItem() { Text = c.Id.ToString(), Value = c.Name });
		}

		public async Task UpdateAsync(PropertyCategory category)
		{
			var dbObject = context.PropertyCategories.FirstOrDefault(c => c.Id.Equals(category.Id));
			dbObject.Name = category.Name;
			dbObject.DisplayOrder = category.DisplayOrder;
			dbObject.CreateDate = category.CreateDate;
			await context.SaveChangesAsync();
		}
	}
}
