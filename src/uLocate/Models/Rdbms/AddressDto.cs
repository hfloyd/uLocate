namespace uLocate.Models.Rdbms
{
    using System;
    using Umbraco.Core.Persistence;
    using Umbraco.Core.Persistence.DatabaseAnnotations;

    /// <summary>
    /// The address DTO.
    /// </summary>
    [TableName("ulocateAddress")]
    [PrimaryKey("pk", autoIncrement = false)]
    [ExplicitColumns]
    internal class AddressDto
    {
        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        [Column("pk")]
        [PrimaryKeyColumn(AutoIncrement = false)]
        [Constraint(Default = "newid()")]
        public Guid Key { get; set; }


        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Column("name")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address 1.
        /// </summary>
        [Column("address1")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the address 2.
        /// </summary>
        [Column("address2")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the locality.
        /// </summary>
        [Column("locality")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string Locality { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        [Column("region")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        [Column("postalCode")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the coordinate.
        /// </summary>
        [Column("coordinate")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string Coordinate { get; set; }

        /// <summary>
        /// Gets or sets the viewport.
        /// </summary>
        [Column("viewport")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string Viewport { get; set; }

        /// <summary>
        /// Gets or sets the extended data.
        /// </summary>
        [Column("extendedData")]
        [NullSetting(NullSetting = NullSettings.Null)]
        [SpecialDbType(SpecialDbTypes.NTEXT)]
        public string ExtendedData { get; set; }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        [Column("countryCode")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        [Column("createDate")]
        [Constraint(Default = "getdate()")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the update date.
        /// </summary>
        [Column("updateDate")]
        [Constraint(Default = "getdate()")]
        public DateTime UpdateDate { get; set; }
    }
}