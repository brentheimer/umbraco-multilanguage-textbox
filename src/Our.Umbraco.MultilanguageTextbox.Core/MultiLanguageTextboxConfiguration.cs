// <copyright file="MultiLanguageTextboxConfiguration.cs" company="Our.Umbraco">
// Copyright (c) Dave Woestenborghs &amp; Contributors
// </copyright>

#if NET472
using Umbraco.Core.PropertyEditors;
#else
using Umbraco.Cms.Core.PropertyEditors;
#endif

namespace Our.Umbraco.MultilanguageTextbox.Core
{
    /// <summary>
    /// Represents the data type configuration.
    /// </summary>
    internal class MultiLanguageTextboxConfiguration
    {
        /// <summary>
        /// Gets or sets a value indicating whether the mandatory language is required, if the property is not marked as mandatory.
        /// </summary>
        [ConfigurationField("isMandatoryLanguageRequired", "Make mandatory language(s) required", "boolean", Description = "Make mandatory language(s) required. Is only applicable if the property is not marked as mandatory")]
        public bool IsMandatoryLanguageRequired { get; set; }
    }
}
