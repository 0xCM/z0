//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    partial struct Sources
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Triples<T> triples<T>(ISource src, int count, T t = default)
            where T : struct
                => triplestream<T>(src).Take(count).Array();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Triples<T> triples<T>(ISource src, Span<Triple<T>> dst, T t = default)
            where T : struct
                => deposit(triplestream<T>(src).Take(dst.Length),dst);
    }
}