using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.UnitOfWork;

namespace uLocate.Integration.Tests.TestHelpers
{
    public class DbPreTestDataWorker
    {
        public UmbracoDatabase Database { get; private set; }

        public DbPreTestDataWorker()
        {
            SqlSyntaxProviderTestHelper.EstablishSqlSyntax();

            var uowProvider = new PetaPocoUnitOfWorkProvider();

            Database = uowProvider.GetUnitOfWork().Database;
        }
    }
}