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

    using VS = ValueSource;
    using BVS = BoundValueSource;

    [ApiHost]
    public readonly struct TripleSource
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Triple<T> next<T>(IValueSource source, T t = default)
            where T : struct
                => Tuples.triple(VS.next(source, t), VS.next(source, t), VS.next(source, t));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static IEnumerable<Triple<T>> stream<T>(IValueSource source, T t = default)
            where T : struct
        {
            while(true)
                yield return next(source, t);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Triples<T> index<T>(IValueSource source, int count, T t = default)
            where T : struct
                => stream(source, t).Take(count).ToArray();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Triples<T> index<T>(IValueSource source, Span<Triple<T>> dst, T t = default)
            where T : struct
                => store(stream(source, t).Take(dst.Length),dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Triples<T> index<T>(IValueSource source, Triple<T>[] dst, T t = default)
            where T : struct
                => store(stream(source, t).Take(dst.Length),dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ConstTriple<T> constant<T>(IValueSource source, T t = default)
            where T : struct
                => (VS.next(source, t), VS.next(source, t), VS.next(source, t));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ConstTriple<T> constant<T>(IBoundValueSource source, T min, T max)
            where T : struct
                => (BVS.next(source,min,max), BVS.next(source,min,max), BVS.next(source,min,max));
    }
}