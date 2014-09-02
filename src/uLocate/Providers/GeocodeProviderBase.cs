namespace uLocate.Providers
{
    using System;
    using Caching;
    using Models;
    using Umbraco.Core.Cache;

    /// <summary>
    /// The geocode provider base.
    /// </summary>
    public abstract class GeocodeProviderBase : IGeocodeProvider
    {
        /// <summary>
        /// The <see cref="IRuntimeCacheProvider"/>
        /// </summary>
        private readonly IRuntimeCacheProvider _cache;

        /// <summary>
        /// The geocode provider settings.
        /// </summary>
        private readonly GeocodeProviderSettings _settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="GeocodeProviderBase"/> class.
        /// </summary>
        protected GeocodeProviderBase()
            : this(new NullCacheProvider())
        {            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeocodeProviderBase"/> class.
        /// </summary>
        /// <param name="cache">
        /// The cache.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Throws an <see cref="ArgumentNullException"/> if the cache parameter is omitted
        /// </exception>
        protected GeocodeProviderBase(IRuntimeCacheProvider cache)            
        {
            if (cache == null) throw new ArgumentNullException("cache");

            _cache = cache;

            _settings = new GeocodeProviderSettings(GetType());
        }
        
        /// <summary>
        /// Gets the runtime cache.
        /// </summary>
        public IRuntimeCacheProvider RuntimeCache
        {
            get { return _cache; } 
        }

        /// <summary>
        /// Queries the API for a geocode
        /// </summary>
        /// <param name="address">
        /// The address.
        /// </param>
        /// <returns>
        /// The <see cref="IGeocodeProviderResponse"/>.
        /// </returns>
        public virtual IGeocodeProviderResponse Geocode(IAddress address)
        {
            return PerformGeocode(address.AsApiRequestFormattedAddressString());
        }

        /// <summary>
        /// Queries the API for a geocode
        /// </summary>
        /// <param name="postalCode">
        /// The postal code.
        /// </param>
        /// <param name="countryCode">
        /// The country code.
        /// </param>
        /// <returns>
        /// The <see cref="IGeocodeProviderResponse"/>.
        /// </returns>
        public virtual IGeocodeProviderResponse Geocode(string postalCode, string countryCode)
        {
            return Geocode(string.Empty, string.Empty, postalCode, countryCode);
        }

        /// <summary>
        /// Queries the API for a geocode
        /// </summary>
        /// <param name="locality">
        /// The locality.
        /// </param>
        /// <param name="region">
        /// The region.
        /// </param>
        /// <param name="postalCode">
        /// The postal code.
        /// </param>
        /// <param name="countryCode">
        /// The country code.
        /// </param>
        /// <returns>
        /// The <see cref="IGeocodeProviderResponse"/>.
        /// </returns>
        public virtual IGeocodeProviderResponse Geocode(string locality, string region, string postalCode, string countryCode)
        {
            return Geocode(string.Empty, string.Empty, locality, region, postalCode, countryCode);
        }

        /// <summary>
        /// Queries the API for a geocode
        /// </summary>
        /// <param name="address1">
        /// The address 1.
        /// </param>
        /// <param name="address2">
        /// The address 2.
        /// </param>
        /// <param name="locality">
        /// The locality.
        /// </param>
        /// <param name="region">
        /// The region.
        /// </param>
        /// <param name="postalCode">
        /// The postal code.
        /// </param>
        /// <param name="countryCode">
        /// The country code.
        /// </param>
        /// <returns>
        /// The <see cref="IGeocodeProviderResponse"/>.
        /// </returns>
        public virtual IGeocodeProviderResponse Geocode(string address1, string address2, string locality, string region, string postalCode, string countryCode)
        {
            return PerformGeocode(AddressExtensions.GetApiRequestFormattedAddressString(address1, address2, locality, region, postalCode, countryCode));
        }

        protected virtual IGeocodeProviderResponse PerformGeocode(string formattedAddress)
        {
            throw new NotImplementedException();
        }
    }
}