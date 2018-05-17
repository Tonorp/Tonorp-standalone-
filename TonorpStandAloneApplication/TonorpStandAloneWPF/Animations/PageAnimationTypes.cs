﻿namespace TonorpStandAloneWPF.Animations
{
    /// <summary>
    /// Styles of page animations for appearing/disappearing
    /// </summary>
    public enum PageAnimationTypes
    {
        /// <summary>
        /// No animation takes place
        /// </summary>
        None = 0,

        /// <summary>
        /// The page slides in and fades in from the right
        /// </summary>
        SlideAndFadeInFromRight = 1,

        /// <summary>
        /// The page slides out and fades out to the left
        /// </summary>
        SlideAndFadeOutToLeft = 2
    }
}
