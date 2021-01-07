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

    partial class text
    {
        [MethodImpl(Inline)]
        public static string delimit<T>(T[] src, char delimiter)
            => Format.delimit(src, delimiter);

        [MethodImpl(Inline)]
        public static string delimit<T>(ReadOnlySpan<T> src, char delimiter)
            => Format.delimit(src, delimiter);

        [MethodImpl(Inline)]
        public static string delimit<T>(IEnumerable<T> src, char delimiter)
            => Format.delimit(src, delimiter);

        [MethodImpl(Inline)]
        public static string nest(params object[] src)
            => Format.nest(src);
    }
}