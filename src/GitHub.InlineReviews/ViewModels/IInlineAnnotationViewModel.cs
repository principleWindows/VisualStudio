﻿using GitHub.Models;

namespace GitHub.InlineReviews.ViewModels
{
    /// <summary>
    /// A view model that represents a single inline annotation.
    /// </summary>
    public interface IInlineAnnotationViewModel
    {
        /// <summary>
        /// Gets the inline annotation model.
        /// </summary>
        IInlineAnnotationModel Model { get; }
    }
}