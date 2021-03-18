//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    partial struct Sources
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Triples<T> triples<T>(ISource src, int count, T t = default)
            where T : struct
                => triplestream(src, t).Take(count).Array();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Triples<T> triples<T>(ISource src, Span<Triple<T>> dst, T t = default)
            where T : struct
                => Pipes.deposit(triplestream(src, t).Take(dst.Length),dst);
    }
}