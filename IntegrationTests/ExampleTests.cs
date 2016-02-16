using System.Collections.Generic;
using System.Linq;
using System.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoGenDBForIntegrationTestsExample;

namespace IntegrationTests
{
	[TestClass]
	public class ExampleTests
	{
		private TestDBCreator _testDBCreator;
		private Context _testDataContext;

		[TestInitialize]
		public void TestInitialize()
		{
			_testDBCreator = new TestDBCreator();
			_testDataContext = _testDBCreator.TestDataContext;
		}

		[TestCleanup]
		public void TestCleanup()
		{
			_testDBCreator.Cleanup();
		}

		[TestMethod]
		public void WhenYouInsert1CustomerNamedBobIntoTheDatabase_Then1CustomerNamedBobExistsInTheDatabase()
		{
			Customer customer = new Customer() {FirstName = "Bob", LastName = "Johnson", Address = new Address() {AddressLineOne = "test way sw", City = "Smallville"} };

			_testDataContext.Customers.Add(customer);

			_testDataContext.SaveChanges();

			List<Customer> customers = _testDataContext.Customers.ToList();

			Assert.AreEqual(1, customers.Count);
			Assert.AreEqual("Bob", customers.First().FirstName);
		}

		[TestMethod]
		public void WhenYouInsert1CustomerNameJoeIntoTheDatabase_Then1CustomerNamedJoeExistsInTheDatabase()
		{
			Customer customer = new Customer() { FirstName = "Joe", LastName = "Johnson", Address = new Address() { AddressLineOne = "test way sw", City = "Smallville" } };

			_testDataContext.Customers.Add(customer);

			_testDataContext.SaveChanges();

			List<Customer> customers = _testDataContext.Customers.ToList();

			Assert.AreEqual(1, customers.Count);
			Assert.AreEqual("Joe", customers.First().FirstName);
		}
	}
}
