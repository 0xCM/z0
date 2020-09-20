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

    using VS = Sourced;
    using BVS = BoundValueSource;

    [ApiHost]
    public readonly struct PairSource
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Pair<T> next<T>(IValueSource source, T t = default)
            where T : struct
                => Tuples.pair(VS.one(source, t), VS.one(source, t));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static IEnumerable<Pair<T>> stream<T>(IValueSource source, T t = default)
            where T : struct
        {
            while(true)
                yield return Sourced.pair(source,t);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Pairs<T> index<T>(IValueSource source, int count, T t = default)
            where T : struct
                => stream(source,t).Take(count).ToArray();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Pairs<T> index<T>(IValueSource source, Span<Pair<T>> dst, T t = default)
            where T : struct
                => store(stream(source, t).Take(dst.Length),dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Pairs<T> index<T>(IValueSource source, Pair<T>[] dst, T t = default)
            where T : struct
                => store(stream(source, t).Take(dst.Length),dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ConstPair<T> constant<T>(IValueSource source, T t = default)
            where T : struct
                => (VS.one(source, t), VS.one(source, t));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ConstPair<T> constant<T>(IBoundValueSource source, T min, T max)
            where T : struct
                => (BVS.next(source,min,max), BVS.next(source,min,max));
    }
}