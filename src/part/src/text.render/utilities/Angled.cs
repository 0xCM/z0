//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XTend
    {
        /// <summary>
        /// Encloses text between less than and greater than characters
        /// </summary>
        /// <param name="content">The content to enclose</param>
        [RenderUtility]
        public static string Angled(this string content)
            => String.IsNullOrWhiteSpace(content) ? EmptyString : $"<{content}>";
    }
}