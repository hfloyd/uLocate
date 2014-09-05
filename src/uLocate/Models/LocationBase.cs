namespace uLocate.Models
{
    using System;

    /// <summary>
    /// A base class for Locations
    /// </summary>
    public class LocationBase : EntityBase, ILocation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationBase"/> class.
        /// </summary>
        /// <param name="extendedData">
        /// The extended data.
        /// </param>
        /// <exception cref="Exception">
        /// Throws an exception if the extended data collection is null
        /// </exception>
        protected LocationBase(ExtendedDataCollection extendedData)
        {
            if (extendedData == null) throw new Exception("Extended Data Collection was null");

            this.ExtendedData = extendedData;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        public Guid LocationTypeKey { get; set; }

        /// <summary>
        /// Gets or sets the recommended viewport.
        /// </summary>
        public IViewport Viewport { get; set; }

        /// <summary>
        /// Gets or sets the coordinate.
        /// </summary>
        public ICoordinate Coordinate { get; set; }

        /// <summary>
        /// Gets or sets the extended data.
        /// </summary>
        public ExtendedDataCollection ExtendedData { get; set; }
    }
}