namespace uLocate.Models
{
    using System;

    /// <summary>
    /// The address.
    /// </summary>
    public class LocatedAddress : LocationBase, ILocatedAddress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocatedAddress"/> class.
        /// </summary>
        public LocatedAddress()
            : this(new ExtendedDataCollection())
        {            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocatedAddress"/> class.
        /// </summary>
        /// <param name="extendedData">
        /// The extended data.
        /// </param>
        /// <exception cref="Exception">
        /// Throws an exception if the extended data collection is null
        /// </exception>
        public LocatedAddress(ExtendedDataCollection extendedData)
            : base(extendedData)
        {
        }

        /// <summary>
        /// Gets or sets the street address line 1.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the street address line 2.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the locality - this is generally the city name
        /// </summary>
        public string Locality { get; set; }

        /// <summary>
        /// Gets or sets the region - this is generally the state or province
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the two letter ISO country code.
        /// </summary>
        public string CountryCode { get; set; }
    }
}