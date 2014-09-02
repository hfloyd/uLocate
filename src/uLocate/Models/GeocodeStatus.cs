namespace uLocate.Models
{
    /// <summary>
    /// The geocode status.
    /// </summary>
    public enum GeocodeStatus
    {
        /// <summary>
        /// Signifies a successful geocode query
        /// </summary>
        Ok,

        /// <summary>
        /// Signifies the API has exceeded it's request limit
        /// </summary>
        OverQueryLimit,

        /// <summary>
        /// Signifies the remote API returned an error
        /// </summary>
        Error
    }
}