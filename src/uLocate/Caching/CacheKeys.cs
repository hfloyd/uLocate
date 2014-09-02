using System;

namespace uLocate.Caching
{
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
        /// <param name="requestUrl">
        /// The request url.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetGeocodeRequestCacheKey(Type provider, string requestUrl)
        {
            return string.Format("ulocate.{0}.{1}", provider.Name, requestUrl);
        }
    }
}