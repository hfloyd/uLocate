namespace uLocate.Models
{
    /// <summary>
    /// Defines a LocatedAddress
    /// </summary>
    public interface ILocation : IEntity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the recommended viewport.
        /// </summary>
        IViewport Viewport { get; set; }

        /// <summary>
        /// Gets or sets the coordinate.
        /// </summary>
        ICoordinate Coordinate { get; set; }
    }
}