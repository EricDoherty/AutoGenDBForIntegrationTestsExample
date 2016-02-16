using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoGenDBForIntegrationTestsExample
{
	public class Customer
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string FirstName { get; set; }

		[StringLength(100)]
		public string MiddleName { get; set; }

		[Required]
		[StringLength(100)]
		public string LastName { get; set; }

		public int Age { get; set; }

		public int AddressId { get; set; }

		public Address Address { get; set; }
		public List<Order> Orders { get; set; }
	}
}
