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

    using static Konst;
    using static z;

    partial struct Sources
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Triples<T> triples<T>(ISource source, int count, T t = default)
            where T : struct
                => triplestream(source, t).Take(count).ToArray();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Triples<T> triples<T>(ISource source, Span<Triple<T>> dst, T t = default)
            where T : struct
                => Sinks.deposit(triplestream(source, t).Take(dst.Length),dst);
    }
}