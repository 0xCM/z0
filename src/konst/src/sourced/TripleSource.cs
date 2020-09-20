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
    public readonly struct TripleSource
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Triples<T> index<T>(IValueSource source, Triple<T>[] dst, T t = default)
            where T : struct
                => store(Sourced.triples(source, t).Take(dst.Length),dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ConstTriple<T> constant<T>(IValueSource source, T t = default)
            where T : struct
                => (VS.one(source, t), VS.one(source, t), VS.one(source, t));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ConstTriple<T> constant<T>(IBoundValueSource source, T min, T max)
            where T : struct
                => (BVS.next(source,min,max), BVS.next(source,min,max), BVS.next(source,min,max));
    }
}