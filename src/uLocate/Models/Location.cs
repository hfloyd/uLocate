namespace uLocate.Models
{
    /// <summary>
    /// The location.
    /// </summary>
    public class Location : EntityBase, ILocation
    {
        /// <summary>
        /// Gets or sets the name.
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
    }
}