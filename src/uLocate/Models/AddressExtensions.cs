namespace uLocate.Models
{
    using System.Linq;

    /// <summary>
    /// Utility extension methods for <see cref="IAddress"/>
    /// </summary>
    public static class AddressExtensions
    {
        /// <summary>
        /// Creates a string used for geocoding requests
        /// </summary>
        /// <param name="address">
        /// The address.
        /// </param>
        /// <returns>
        /// The address formatted as a single string.
        /// </returns>
        public static string AsApiRequestFormattedAddressString(this IAddress address)
        {
            return GetApiRequestFormattedAddressString(address.Address1, address.Address2, address.Locality, address.Region, address.PostalCode, address.CountryCode);
        }

        /// <summary>
        /// Creates an address formatted as a single string.
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
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetApiRequestFormattedAddressString(string address1, string address2, string locality, string region, string postalCode, string countryCode)
        {
            var segments = new[]
            {
                string.Concat(address1, " ", address2),
                locality ?? string.Empty,
                string.Concat(region, " ", postalCode),
                countryCode ?? string.Empty
            };

            return string.Join(", ", segments.Select(x => x.Trim()).Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}