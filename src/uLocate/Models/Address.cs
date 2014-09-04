namespace uLocate.Models
{
    using System;

    /// <summary>
    /// The address.
    /// </summary>
    public class Address : EntityBase, IAddress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address()
            : this(new ExtendedDataCollection())
        {            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="extendedData">
        /// The extended data.
        /// </param>
        /// <exception cref="Exception">
        /// Throws an exception if the extended data collection is null
        /// </exception>
        public Address(ExtendedDataCollection extendedData)
        {
            if (extendedData == null) throw new Exception("Extended Data Collection was null");

            ExtendedData = extendedData;
        }

        /// <summary>
        /// Gets or sets the name associated with the address.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the viewport.
        /// </summary>
        public IViewport Viewport { get; set; }

        /// <summary>
        /// Gets or sets the coordinate.
        /// </summary>
        public ICoordinate Coordinate { get; set; }

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

        /// <summary>
        /// Gets or sets the extended data collection
        /// </summary>
        public ExtendedDataCollection ExtendedData { get; set; }
    }
}