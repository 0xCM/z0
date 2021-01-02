//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines comment classifiers
    /// </summary>
    public enum CommentKind
    {
        None,

        /// <summary>
        /// Comment follows code on same line
        /// </summary>
        PostFix,

        /// <summary>
        /// Comment is self-contained within a line of code
        /// </summary>
        Embedded,

        /// <summary>
        /// Comment occupies an enire line
        /// </summary>
        Line,

        /// <summary>
        /// Comment occupies multiple lines
        /// </summary>
        Paragraph,
    }

}