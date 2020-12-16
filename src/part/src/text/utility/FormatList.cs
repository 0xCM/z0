//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class XText
    {
        /// <summary>
        /// Formats a sequence of objects as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter, if specified; otherwise, a system default is chosen</param>
        /// <typeparam name="T">A formattable type</typeparam>
        [TextUtility]
        public static string FormatList(this IEnumerable<object> items, char sep = Chars.Comma)
            => string.Join(sep, items);

        /// <summary>
        /// Formats a sequence of objects as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter, if specified; otherwise, a system default is chosen</param>
        /// <typeparam name="T">A formattable type</typeparam>
        [TextUtility, Closures(Closure)]
        public static string FormatList<T>(this IEnumerable<T> items, string sep)
            => string.Join(sep, items);

        /// <summary>
        /// Formats a sequence of objects as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter, if specified; otherwise, a system default is chosen</param>
        /// <typeparam name="T">A formattable type</typeparam>
        [TextUtility]
        public static string FormatList<T>(this IIndex<T> items, string sep)
            => string.Join(sep, items);
    }
}