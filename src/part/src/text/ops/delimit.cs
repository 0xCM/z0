//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static TextRules;
    using static memory;

    partial class text
    {
        [Op, Closures(Closure)]
        public static string delimit<T>(T[] src, char delimiter)
            => Format.delimit(src, delimiter);

        [Op, Closures(Closure)]
        public static string delimit<T>(IEnumerable<T> src, char delimiter)
            => Format.delimit(src, delimiter);

        [Op, Closures(Closure)]
        public static string delimit<T>(ReadOnlySpan<T> src, char delimiter, int pad)
            => Format.delimit(src, delimiter, pad);

        [Op, Closures(Closure)]
        public static string delimit<T>(IEnumerable<T> src, char delimiter, int pad)
            => Format.delimit(src.ToSpan().ReadOnly(), delimiter, pad);
    }
}