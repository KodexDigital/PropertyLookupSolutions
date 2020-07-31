using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Model.DB;
using System.Repository.IRepository;
using System.Text;

namespace System.Model
{
	[DisplayName("Create new property service")]
	public class PropertyService : BaseModel, IPseudoDeletable, ISystemCreatedUser
	{
		public string PropertName { get; set; }
		public double PropertyWorth { get; set; }
		public double SellingPrice { get; set; }
		public double LeasingPrice { get; set; }
		public string Location { get; set; }
		public string LandMark { get; set; }
		public string Descriptions { get; set; }
		public bool Delete { get; set; }
		public string CreatedUserId { get; set; }

		public string ApplicationUserId { get; set; }
		[ForeignKey("ApplicationUserId")]
		public virtual ApplicationUser ApplicationUser { get; set; }
	}
}
