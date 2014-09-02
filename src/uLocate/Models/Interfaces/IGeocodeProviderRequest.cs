namespace uLocate.Models
{
    /// <summary>
    /// Defines a GeocodeProviderRequest
    /// </summary>
    public interface IGeocodeProviderRequest
    {
        /// <summary>
        /// Gets or sets the request method - GET or POST
        /// </summary>
        RequestMethod RequestMethod { get; set; }

        /// <summary>
        /// Gets or sets the url of the API end point
        /// </summary>
        string Url { get; set; }

        /// <summary>
        /// Gets or sets the data - only used in POST
        /// </summary>
        string Data { get; set; }
    }
}