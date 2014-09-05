namespace uLocate.Persistance.Factories
{
    using System.Linq;

    using uLocate.Helpers;
    using uLocate.Models;
    using uLocate.Models.Rdbms;

    /// <summary>
    /// The located address factory.
    /// </summary>
    internal class LocatedAddressFactory
    {
        /// <summary>
        /// Builds a <see cref="LocatedAddress"/> from an <see cref="IAddress"/> and <see cref="GeocodeProviderResponse"/>
        /// </summary>
        /// <param name="address">
        /// The address.
        /// </param>
        /// <param name="response">
        /// The response.
        /// </param>
        /// <param name="extendedData">
        /// The extended data.
        /// </param>
        /// <returns>
        /// The <see cref="LocatedAddress"/>.
        /// </returns>
        public LocatedAddress BuildLocatedAddress(IAddress address, IGeocodeProviderResponse response, ExtendedDataCollection extendedData = null)
        {

            var locatedAddress = AutoMapper.Mapper.Map<LocatedAddress>(address);

            if (extendedData != null) locatedAddress.ExtendedData = extendedData;

            if (response.Status != GeocodeStatus.Ok) return locatedAddress;
            if (!response.Results.Any()) return locatedAddress;

            var result = response.Results.First();

            locatedAddress.Viewport = result.Viewport;
            locatedAddress.Coordinate = new Coordinate() { Latitude = result.Latitude, Longitude = result.Longitude };

            return locatedAddress;
        }

        /// <summary>
        /// Builds a DTO from a <see cref="ILocatedAddress"/>
        /// </summary>
        /// <param name="locatedAddress">
        /// The located address.
        /// </param>
        /// <returns>
        /// The <see cref="LocatedAddressDto"/>.
        /// </returns>
        public LocatedAddressDto BuildDto(ILocatedAddress locatedAddress)
        {
            var helper = new GeographyHelper();

            return new LocatedAddressDto()
                {
                    Key = locatedAddress.Key,
                    Name = locatedAddress.Name,
                    Address1 = locatedAddress.Address1,
                    Address2 = locatedAddress.Address2,
                    Locality = locatedAddress.Locality,
                    Region = locatedAddress.Region,
                    PostalCode = locatedAddress.PostalCode,
                    CountryCode = locatedAddress.CountryCode,
                    Coordinate = helper.GetStPointText(locatedAddress.Coordinate),
                    Viewport = helper.GetStLineString(locatedAddress.Viewport),
                    ExtendedData = locatedAddress.ExtendedData.SerializeToXml(),
                    CreateDate = locatedAddress.CreateDate,
                    UpdateDate = locatedAddress.UpdateDate
                };
        }
    }
}