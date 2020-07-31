using System;
using System.Collections.Generic;
using System.Model;
using System.Model.DB;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace System.DAL.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<PropertyService> propertyServices { get; set; }
		public DbSet<PropertyCategory> PropertyCategories { get; set; }
		public DbSet<Frequency> Frequencies { get; set; }
	}
}
