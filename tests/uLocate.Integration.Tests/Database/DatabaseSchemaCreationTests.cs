using NUnit.Framework;
using uLocate.Integration.Tests.TestHelpers;
using uLocate.Persistance.Migrations;
using Umbraco.Core.Persistence;

namespace uLocate.Integration.Tests.Database
{
    [TestFixture]
    public class DatabaseSchemaCreationTests
    {
        private UmbracoDatabase _database;

        [TestFixtureSetUp]
        public void Init()
        {
            var worker = new DbPreTestDataWorker();

            _database = worker.Database;
        }

        [Test]
        public void Successfully_Create_Default_Database_Schema()
        {
            //// Arrange
            var creation = new DatabaseSchemaCreation(_database);

            //// Act
            creation.InitializeDatabaseSchema();           
        }

        [Test]
        public void Successfully_Uninstall_The_Database()
        {
            //// Arrange
            var creation = new DatabaseSchemaCreation(_database);

            //// Act
            creation.UninstallDatabaseSchema();
        }
    }
}