namespace uLocate.Persistance.Repositories
{
    using System;
    using System.Collections.Generic;

    using uLocate.Models;

    using Umbraco.Core.Cache;
    using Umbraco.Core.Persistence;

    /// <summary>
    /// Represents the <see cref="LocatedAddressRepository"/>.
    /// </summary>
    internal class LocatedAddressRepository : RepositoryBase<ILocatedAddress>, ILocatedAddressRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocatedAddressRepository"/> class.
        /// </summary>
        /// <param name="database">
        /// The database.
        /// </param>
        /// <param name="cache">
        /// The cache.
        /// </param>
        public LocatedAddressRepository(UmbracoDatabase database, IRuntimeCacheProvider cache)
            : base(database, cache)
        {
        }

        /// <summary>
        /// Does the actual work of getting all the entities.
        /// </summary>
        /// <param name="keys">
        /// The keys.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable{ILocatedAddress}"/>.
        /// </returns>
        protected override IEnumerable<ILocatedAddress> PerformGetAll(params Guid[] keys)
        {
            throw new NotImplementedException();
        }

        protected override Page<ILocatedAddress> Page(long page, long itemsPerPage, Sql sql)
        {
            throw new NotImplementedException();
        }

        protected override ILocatedAddress PerformGet(Guid key)
        {
            throw new NotImplementedException();
        }

        protected override void PersistNewItem(ILocatedAddress item)
        {
            throw new NotImplementedException();
        }

        protected override void PersistUpdatedItem(ILocatedAddress item)
        {
            throw new NotImplementedException();
        }

        protected override void PersistDeletedItem(ILocatedAddress item)
        {
            throw new NotImplementedException();
        }

        protected override int PerformCount(Sql sql)
        {
            throw new NotImplementedException();
        }

        protected override Sql GetBaseQuery(bool isCount)
        {
            throw new NotImplementedException();
        }

        protected override string GetBaseWhereClause()
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<string> GetDeleteClauses()
        {
            throw new NotImplementedException();
        }
    }
}