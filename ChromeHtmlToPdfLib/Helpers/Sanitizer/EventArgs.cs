﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using AngleSharp.Css.Dom;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable CollectionNeverUpdated.Global

namespace ChromeHtmlToPdfLib.Helpers.Sanitizer
{
    #region Internal class PostProcessDomEventArgs
    /// <summary>
    /// Provides data for the <see cref="HtmlSanitizer.PostProcessDom"/> event.
    /// </summary>
    internal class PostProcessDomEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets the document.
        /// </summary>
        /// <value>
        /// The document.
        /// </value>
        public IHtmlDocument Document { get; set; }
    }
    #endregion

    #region Internal class PostProcessNodeEventArgs
    /// <summary>
    /// Provides data for the <see cref="HtmlSanitizer.PostProcessNode"/> event.
    /// </summary>
    internal class PostProcessNodeEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets the document.
        /// </summary>
        /// <value>
        /// The document.
        /// </value>
        public IHtmlDocument Document { get; set; }

        /// <summary>
        /// Gets or sets the DOM node to be processed.
        /// </summary>
        /// <value>
        /// The DOM node.
        /// </value>
        public INode Node { get; set; }

        /// <summary>
        /// Gets the replacement nodes. Leave empty if no replacement should occur.
        /// </summary>
        /// <value>
        /// The replacement nodes.
        /// </value>
        public IList<INode> ReplacementNodes { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostProcessNodeEventArgs"/> class.
        /// </summary>
        public PostProcessNodeEventArgs()
        {
            ReplacementNodes = new List<INode>();
        }
    }
    #endregion

    #region Internal class RemovingTagEventArgs
    /// <summary>
    /// Provides data for the <see cref="HtmlSanitizer.RemovingTag"/> event.
    /// </summary>
    internal class RemovingTagEventArgs : CancelEventArgs
    {
        /// <summary>
        /// Gets or sets the tag to be removed.
        /// </summary>
        /// <value>
        /// The tag.
        /// </value>
        public IElement Tag { get; set; }

        /// <summary>
        /// Gets or sets the reason why the tag will be removed
        /// </summary>
        /// <value>
        /// The reason.
        /// </value>
        public RemoveReason Reason { get; set; }
    }
    #endregion

    #region Internal class RemovingAttributeEventArgs
    /// <summary>
    /// Provides data for the <see cref="HtmlSanitizer.RemovingAttribute"/> event.
    /// </summary>
    internal class RemovingAttributeEventArgs : CancelEventArgs
    {
        /// <summary>
        /// Gets or sets the tag containing the attribute to be removed.
        /// </summary>
        /// <value>
        /// The tag.
        /// </value>
        public IElement Tag { get; set; }

        /// <summary>
        /// Gets or sets the attribute to be removed.
        /// </summary>
        /// <value>
        /// The attribute.
        /// </value>
        public IAttr Attribute { get; set; }

        /// <summary>
        /// Gets or sets the reason why the attribute will be removed
        /// </summary>
        /// <value>
        /// The reason.
        /// </value>
        public RemoveReason Reason { get; set; }
    }
    #endregion

    #region Internal class RemovingStyleEventArgs
    /// <summary>
    /// Provides data for the <see cref="HtmlSanitizer.RemovingStyle"/> event.
    /// </summary>
    internal class RemovingStyleEventArgs : CancelEventArgs
    {
        /// <summary>
        /// Gets or sets the tag containing the style to be removed.
        /// </summary>
        /// <value>
        /// The tag.
        /// </value>
        public IElement Tag { get; set; }

        /// <summary>
        /// Gets or sets the style to be removed.
        /// </summary>
        /// <value>
        /// The style.
        /// </value>
        public ICssProperty Style { get; set; }

        /// <summary>
        /// Gets or sets the reason why the style will be removed
        /// </summary>
        /// <value>
        /// The reason.
        /// </value>
        public RemoveReason Reason { get; set; }
    }
    #endregion

    #region Internal class RemovingAtRuleEventArgs
    /// <summary>
    /// Provides data for the <see cref="HtmlSanitizer.RemovingAtRule"/> event.
    /// </summary>
    internal class RemovingAtRuleEventArgs : CancelEventArgs
    {
        /// <summary>
        /// Gets or sets the tag containing the at-rule to be removed.
        /// </summary>
        /// <value>
        /// The tag.
        /// </value>
        public IElement Tag { get; set; }

        /// <summary>
        /// Gets or sets the rule to be removed.
        /// </summary>
        /// <value>
        /// The rule.
        /// </value>
        public ICssRule Rule { get; set; }
    }
    #endregion

    #region Internal class RemovingCommentEventArgs
    /// <summary>
    /// Provides data for the <see cref="HtmlSanitizer.RemovingComment"/> event.
    /// </summary>
    internal class RemovingCommentEventArgs : CancelEventArgs
    {
        /// <summary>
        /// Gets or sets the comment node to be removed.
        /// </summary>
        /// <value>
        /// The comment node.
        /// </value>
        public IComment Comment { get; set; }
    }
    #endregion

    #region Internal class RemovingCssClassEventArgs
    /// <summary>
    /// Provides data for the <see cref="HtmlSanitizer.RemovingCssClass"/> event.
    /// </summary>
    internal class RemovingCssClassEventArgs : CancelEventArgs
    {
        /// <summary>
        /// Gets or sets the tag containing the CSS class to be removed.
        /// </summary>
        /// <value>
        /// The tag.
        /// </value>
        public IElement Tag { get; set; }

        /// <summary>
        /// Gets or sets the CSS class to be removed.
        /// </summary>
        /// <value>
        /// The CSS class.
        /// </value>
        public string CssClass { get; set; }

        /// <summary>
        /// Gets or sets the reason why the CSS class will be removed.
        /// </summary>
        /// <value>
        /// The reason.
        /// </value>
        public RemoveReason Reason { get; set; }
    }
    #endregion

    #region Internal class FilterUrlEventArgs
    /// <summary>
    /// Provides data for the <see cref="HtmlSanitizer.FilterUrl"/> event.
    /// </summary>
    internal class FilterUrlEventArgs: EventArgs
    {
        /// <summary>
        /// Gets or sets the original URL.
        /// </summary>
        /// <value>
        /// The original URL.
        /// </value>
        public string OriginalUrl { get; set; }

        /// <summary>
        /// Gets or sets the sanitized URL.
        /// </summary>
        /// <value>
        /// The sanitized URL. If it is null, it will be removed.
        /// </value>
        public string SanitizedUrl { get; set; }
    }
    #endregion
}
