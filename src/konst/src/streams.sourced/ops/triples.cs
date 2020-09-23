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

    partial struct Sourced
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static IEnumerable<Triple<T>> triples<T>(IValueSource source, T t = default)
            where T : struct
        {
            while(true)
                yield return triple(source, t);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Triples<T> triples<T>(IValueSource source, int count, T t = default)
            where T : struct
                => Sourced.triples(source, t).Take(count).ToArray();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Triples<T> triples<T>(IValueSource source, Span<Triple<T>> dst, T t = default)
            where T : struct
                => store(Sourced.triples(source, t).Take(dst.Length),dst);
    }
}