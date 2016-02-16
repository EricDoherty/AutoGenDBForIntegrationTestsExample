using System.ComponentModel.DataAnnotations;

namespace AutoGenDBForIntegrationTestsExample
{
	public class Item
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		[StringLength(100)]
		public string BrandName { get; set; }

		[Required]
		public double Cost { get; set; }

		public int OrderId { get; set; }

		public Order Order { get; set; }
	}
}
