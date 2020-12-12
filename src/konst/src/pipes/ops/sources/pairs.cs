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
        public static Pairs<T> pairs<T>(ISource source, int count)
            where T : struct
                => Streams.pairs<T>(source).Take(count).Array();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Pairs<T> pairs<T>(ISource source, Span<Pair<T>> dst)
            where T : struct
                => Sinks.deposit(Streams.pairs<T>(source).Take(dst.Length),dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Pairs<T> pairs<T>(ISource source, Pair<T>[] dst)
            where T : struct
                => Sinks.deposit(Streams.pairs<T>(source).Take(dst.Length), dst);
    }
}