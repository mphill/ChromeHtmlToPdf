﻿namespace ChromeHtmlToPdfLib.Helpers.Sanitizer
{
    /// <summary>
    /// List of reasons why something was identified to get removed from the HTML
    /// </summary>
    internal enum RemoveReason
    {
        /// <summary>
        /// Tag is not allowed
        /// </summary>
        NotAllowedTag,

        /// <summary>
        /// Attribute is not allowed
        /// </summary>
        NotAllowedAttribute,

        /// <summary>
        /// Style is not allowed
        /// </summary>
        NotAllowedStyle,

        /// <summary>
        /// Value is a non-allowed or harmful url
        /// </summary>
        NotAllowedUrlValue,

        /// <summary>
        /// Value is not allowed or harmful
        /// </summary>
        NotAllowedValue,

        /// <summary>
        /// CSS Class is not allowed
        /// </summary>
        NotAllowedCssClass,

        /// <summary>
        /// The class attribute is empty
        /// </summary>
        ClassAttributeEmpty,

        /// <summary>
        /// The style attribute is empty
        /// </summary>
        StyleAttributeEmpty,
    }
}
