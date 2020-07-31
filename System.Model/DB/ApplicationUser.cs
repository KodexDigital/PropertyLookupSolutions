using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace System.Model.DB
{
	public class ApplicationUser : IdentityUser
	{
		public string ContactAddress { get; set; }
	}
}
