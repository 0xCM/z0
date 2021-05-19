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

    partial struct Seq
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedSpan<T> delimit<T>(char delimiter, int pad, Span<T> src)
            => new DelimitedSpan<T>(src, delimiter, pad);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedSpan<T> delimit<T>(char delimiter, int pad, ReadOnlySpan<T> src)
            => new DelimitedSpan<T>(src, delimiter, pad);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<T> delimit<T>(char delimiter, int pad, IEnumerable<T> src)
            => new DelimitedIndex<T>(src.Array(), delimiter, pad);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<T> delimit<T>(char delimiter, int pad, T[] src)
            where T : unmanaged
                => new DelimitedIndex<T>(src, unspaced, delimiter, pad);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<object> delimit(char delimiter, int pad, params object[] src)
            => new DelimitedIndex<object>(src, delimiter, pad);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<string> delimit(char delimiter, int pad, params string[] src)
            => new DelimitedIndex<string>(src, delimiter, pad);

        [Op, Closures(Closure)]
        static string unspaced<T>(ReadOnlySpan<T> src, char delimiter, int pad)
            => text.delimit(src, delimiter, pad,false);
    }
}