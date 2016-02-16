using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGenDBForIntegrationTestsExample
{
	public class Context : DbContext
	{
		public Context(string connectionString ) : base(connectionString)
		{
		}

		public DbSet<Customer> Customers { get; set; }
		public DbSet<Item> Items { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Address> Addresses { get; set; }
	}
}
