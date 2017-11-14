using System.Collections.Generic;
using Taxi_Pay.Framework.Domain.BaseModule;

namespace Rayak.Framework.Domain.BaseModule
{
    /// <summary>
    /// Represents a language
    /// </summary>
    public class Language : Entity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the language culture
        /// </summary>
        public string LanguageCulture { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the language supports "Right-to-left"
        /// </summary>
        public bool Rtl { get; set; }

        /// <summary>
        /// Gets or sets locale string resources
        /// </summary>
        public ICollection<LocaleStringResource> LocaleStringResources { get; set; } 
    }

    /// <summary>
    /// Represents a locale string resource
    /// </summary>
    public class LocaleStringResource : Entity
    {
        /// <summary>
        /// Gets or sets the language identifier
        /// </summary>
        public int LanguageId { get; set; }

        /// <summary>
        /// Gets or sets the resource name
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// Gets or sets the resource value
        /// </summary>
        public string ResourceValue { get; set; }

        /// <summary>
        /// Gets or sets the language
        /// </summary>
        public virtual Language Language { get; set; }
    }
}
