//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    partial class XTend
    {
        public static IEnumerable<string> FormatLines<F>(this IEnumerable<F> items)
            where F : ICustomFormattable
                => items.Select(m => m.Format());                

        /// <summary>
        /// Formats each source element on a new line
        /// </summary>
        /// <param name="src">The source span</param>
        public static string FormatLines<T>(this ReadOnlySpan<T> src)
        {
            var lines = string.Empty.Build();
            for(var i=0; i<src.Length; i++)
                lines.AppendLine(src[i].ToString());
            return lines.ToString();
        }

        /// <summary>
        /// Formats each source element on a new line
        /// </summary>
        /// <param name="src">The source span</param>
        public static string FormatLines<T>(this Span<T> src)
            => src.ReadOnly().FormatLines();
    }
}