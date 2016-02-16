using AutoGenDBForIntegrationTestsExample;
using System;
using System.Data.SqlClient;

namespace IntegrationTests
{
	public class TestDBCreator
	{
		public Context TestDataContext { get; set; }

		public TestDBCreator()
		{
			try
			{
				TestDataContext = new Context(CreateNewRandomDBConnectionString());
				TestDataContext.Database.CreateIfNotExists();

				InitializeData();
			}
			catch (Exception)
			{
				// Cleans up the database if something fails since the TestDBCreator is often created in the testInitialize method
				// and TestCleanup is not ran if the TestInitialize throws an exception
				Cleanup();
				throw;
			}
		}

		public void Cleanup()
		{
			if (TestDataContext != null)
			{
				TestDataContext.Database.Delete();
			}
		}

		private void InitializeData()
		{
			// Create data using SQL scripts or adding data through the context itself

			//Context.Database.ExecuteSqlCommand(File.ReadAllText(String.Format("{0}\SQLDataInitializationScripts\DataInitializationScript.sql", Directory.GetCurrentDirectory())))
		}

		private string CreateNewRandomDBConnectionString()
		{
			return new SqlConnectionStringBuilder
			{
				DataSource = "(local)\\SQLExpress",
				InitialCatalog = string.Format("DB{0}", Guid.NewGuid().ToString().Replace("-", "")),
				IntegratedSecurity = true
			}.ToString();
		}
	}
}
