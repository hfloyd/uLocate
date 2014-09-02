namespace uLocate.Configuration
{
    using System.Configuration;

    /// <summary>
    /// The settings collection.
    /// </summary>
    public class SettingsCollection : ConfigurationElementCollection
    {
        /// <summary>
        /// Default. Returns the SettingElement with the index of index from the collection
        /// </summary>
        /// <returns>The <see cref="SettingElement"/></returns>
        public SettingElement this[object index]
        {
            get { return (SettingElement)this.BaseGet(index); }
        }

        /// <summary>
        /// Creates a new <see cref="ConfigurationElement">ConfigurationElement</see>.
        /// CreateNewElement must be overridden in classes that derive from the ConfigurationElementCollection class.
        /// </summary>
        /// <returns>
        /// The <see cref="ConfigurationElement"/>.
        /// </returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new SettingElement();
        }

        /// <summary>
        /// Gets the element key for a specified configuration element when overridden in a derived class.
        /// </summary>
        /// <param name="element">
        /// The <see cref="SettingElement"/>
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((SettingElement)element).Key;
        }

    }
}
