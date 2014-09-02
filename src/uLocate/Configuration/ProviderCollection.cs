using System.Configuration;

namespace uLocate.Configuration
{
    public class ProviderCollection : ConfigurationElementCollection
    {
        /// <summary>
        /// Creates a new <see cref="ConfigurationElement">ConfigurationElement</see>.
        /// CreateNewElement must be overridden in classes that derive from the ConfigurationElementCollection class.
        /// </summary>
        protected override ConfigurationElement CreateNewElement()
        {
            return new ProviderElement();
        }

        /// <summary>
        /// Gets the element key for a specified configuration element when overridden in a derived class.
        /// </summary>
        /// <param name="element">DataTypeElement</param>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ProviderElement)element).Name;
        }

        /// <summary>
        /// Default. Returns the ProviderElement with the index of index from the collection
        /// </summary>
        public ProviderElement this[object index]
        {
            get { return (ProviderElement)this.BaseGet(index); }
        }
    }
}