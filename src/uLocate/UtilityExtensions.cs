namespace uLocate.Models
{
    /// <summary>
    /// Utility extension methods
    /// </summary>
    public static class UtilityExtensions
    {
        /// <summary>
        /// The is zero zero.
        /// </summary>
        /// <param name="coordinate">
        /// The coordinate.
        /// </param>
        /// <returns>
        /// True if the coordinate is 0,0 otherwise returns false.
        /// </returns>
        public static bool IsZeroZero(this ICoordinate coordinate)
        {
            return coordinate.Latitude.Equals(0) && coordinate.Longitude.Equals(0);
        }

    }
}