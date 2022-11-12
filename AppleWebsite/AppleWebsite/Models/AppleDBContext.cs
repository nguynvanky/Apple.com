using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace AppleWebsite.Models
{
	public class AppleDBContext:DbContext
	{
		public AppleDBContext() : base("AppleConnectionString")
		{

		}
		public DbSet<Device> Devices { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Cart> Carts { get; set; }
	}
}