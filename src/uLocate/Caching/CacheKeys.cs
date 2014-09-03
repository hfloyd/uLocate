namespace uLocate.Caching
{
    using System;

    /// <summary>
    /// A utility class to assist in building and maintaining unique cache keys
    /// </summary>
    internal class CacheKeys
    {
        /// <summary>
        /// The get geocode request cache key.
        /// </summary>
        /// <param name="provider">
        /// The provider.
        /// </param>
        /// <param name="formattedAddress">
        /// The formatted address
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetGeocodeRequestCacheKey(Type provider, string formattedAddress)
        {
            return string.Format("ulocate.{0}.{1}", provider.Name, formattedAddress);
        }
    }
}