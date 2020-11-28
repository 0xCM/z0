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
        public static Pairs<T> pairs<T>(ISource source, int count, T t = default)
            where T : struct
                => Streams.pairs(source,t).Take(count).Array();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Pairs<T> pairs<T>(ISource source, Span<Pair<T>> dst, T t = default)
            where T : struct
                => Sinks.deposit(Streams.pairs(source, t).Take(dst.Length),dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Pairs<T> pairs<T>(ISource source, Pair<T>[] dst, T t = default)
            where T : struct
                => Sinks.deposit(Streams.pairs(source, t).Take(dst.Length),dst);
    }
}