//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Formats a span of natural length as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <typeparam name="N">The length type</typeparam>
        public static string FormatList<N,T>(this NatSpan<N,T> src, char delimiter = ',', int offset = 0, int pad = 2)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Edit.Format(delimiter, offset, pad);

        /// <summary>
        /// Formats a sequence of objects as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter, if specified; otherwise, a system default is chosen</param>
        /// <typeparam name="T">A formattable type</typeparam>
        public static string FormatList(this IEnumerable<object> items, char sep = Chars.Comma)
            => string.Join(sep, items);

        /// <summary>
        /// Formats a sequence of objects as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter, if specified; otherwise, a system default is chosen</param>
        /// <typeparam name="T">A formattable type</typeparam>
        public static string FormatList<T>(this IEnumerable<T> items, string sep)
            => string.Join(sep, items);

        /// <summary>
        /// Formats a sequence of objects as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter, if specified; otherwise, a system default is chosen</param>
        /// <typeparam name="T">A formattable type</typeparam>
        public static string FormatList<T>(this IIndex<T> items, string sep)
            => string.Join(sep, items);

    }
}