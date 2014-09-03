using NUnit.Framework;
using uLocate.Caching;
using uLocate.Models;
using uLocate.Plugins.Geocode.GoogleMaps;

namespace uLocate.Integration.Tests.Geocoding
{
    [TestFixture]
    public class GoogleMapsGeocodeProviderTests
    {
        private IAddress _address;

        [TestFixtureSetUp]
        public void Init()
        {
            _address = new Address()
            {
                Address1 = "114 W. Magnolia St.",
                Address2 = "Suite 300",
                Locality = "Bellingham",
                Region = "WA",
                CountryCode = "US"
            };
        }

        [Test]
        public void Can_GeoCode_An_Address()
        {
            //// Arrage
            var provider = new GoogleMapsGeocodeProvider(new NullCacheProvider());

            //// Act
            var response = provider.Geocode(_address);

            //// Assert
            Assert.NotNull(response);
        }
    }
}