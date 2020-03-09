//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    public static partial class TextExtensions
    {
        /// <summary>
        /// Formats a sequence of objects as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter, if specified; otherwise, a system default is chosen</param>
        /// <param name="offset">The index of the source element at which formatting will begin</param>
        /// <typeparam name="T">A formattable type</typeparam>
        public static string FormatList(this IEnumerable<object> items, char? delimiter = null)
            => string.Join(delimiter ?? text.comma(), items);
    }
}