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

    using static Part;
    using static memory;

    partial struct Seq
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<object> delimit(params object[] src)
            => new DelimitedIndex<object>(src, FieldDelimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<T> delimit<T>(params T[] src)
            where T : unmanaged
                => new DelimitedIndex<T>(src, text.delimit, FieldDelimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<T> delimit<T>(char delimiter, params T[] src)
            => new DelimitedIndex<T>(src, text.delimit, delimiter);

        [MethodImpl(Inline)]
        public static DelimitedIndex<T> delimit<T>(IList<T> src, char delimiter = FieldDelimiter)
            => new DelimitedIndex<T>(src.ToArray(), delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<T> delimit<T>(Span<T> src, char delimiter = FieldDelimiter)
            => new DelimitedIndex<T>(array(src), delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<T> delimit<T>(ReadOnlySpan<T> src, char delimiter = FieldDelimiter)
            => new DelimitedIndex<T>(src.ToArray(), delimiter);
    }
}