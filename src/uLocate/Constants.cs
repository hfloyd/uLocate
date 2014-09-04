namespace uLocate
{
    using System.Configuration;

    /// <summary>
    /// uLocate constants
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// Gets the Umbraco Package Name
        /// </summary>
        public static string PackageName
        {
            get { return "uLocate"; }
        }

        /// <summary>
        /// The database connection info.
        /// </summary>
        public static class DatabaseConnectionInfo
        {
            /// <summary>
            /// Gets the connection string.
            /// </summary>
            public static string ConnectionString
            {
                get { return ConfigurationManager.ConnectionStrings["umbracoDbDSN"].ConnectionString; }
            }

            /// <summary>
            /// Gets the provider name.
            /// </summary>
            public static string ProviderName
            {
                get { return ConfigurationManager.ConnectionStrings["umbracoDbDSN"].ProviderName; }
            }
        }


        /// <summary>
        /// Gets the world geodetic coordinate system SRID (spacial reference Id)
        /// </summary>
        public static int WorldGeodeticSystemSrid
        {
            get { return 4326; }
        }

        /// <summary>
        /// Mime type names
        /// </summary>
        public static class MimeTypeNames
        {
            /// <summary>
            /// Application mime types
            /// </summary>
            public static class Application
            {
                /// <summary>
                /// Gets the java script application mime type
                /// </summary>
                public static string JavaScript
                {
                    get { return "application/x-javascript"; }
                }

                /// <summary>
                /// Gets the JSON application mime type
                /// </summary>
                public static string Json
                {
                    get { return "application/json";  }
                }
            }

            /// <summary>
            /// Text mime types
            /// </summary>
            public static class Text
            {
                /// <summary>
                /// Gets the css mime type
                /// </summary>
                public static string Css 
                { 
                    get { return "text/css"; }
                }

                /// <summary>
                /// Gets the csv mime type
                /// </summary>
                public static string Csv
                {
                    get { return "text/csv"; }
                }
            }
        }
    }
}