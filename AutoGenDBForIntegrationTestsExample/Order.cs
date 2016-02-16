using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoGenDBForIntegrationTestsExample
{
	public class Order
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public int CustomerId { get; set; }

		[Required]
		public Customer Customer { get; set; }

		public List<Item> Items { get; set; }
	}
}
