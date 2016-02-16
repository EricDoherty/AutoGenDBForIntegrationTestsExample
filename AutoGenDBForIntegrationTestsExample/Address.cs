using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoGenDBForIntegrationTestsExample
{
	public class Address
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string AddressLineOne { get; set; }

		[StringLength(100)]
		public string AddressLineTwo { get; set; }

		[StringLength(100)]
		public string AddressLineThree { get; set; }

		[Required]
		[StringLength(50)]
		public string City { get; set; }

		[StringLength(2)]
		public string StateCode { get; set; }

		[StringLength(9)]
		public string ZipCode { get; set; }

		public List<Customer> Customers { get; set; } 

	}
}
