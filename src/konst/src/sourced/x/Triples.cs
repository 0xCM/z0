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

    partial class XTend
    {
        public static Triple<T> Triple<T>(this IValueSource source, T t = default)
            where T : struct
                => TripleSource.next(source, t);

        public static IEnumerable<Triple<T>> TripleStream<T>(this IValueSource source, T t = default)
            where T : struct
                => TripleSource.stream(source, t);

        public static Triples<T> Triples<T>(this IValueSource source, int count, T t = default)
            where T : struct
                => TripleSource.index(source, count, t);

        public static Triples<T> Triples<T>(this IValueSource source, Span<Triple<T>> dst)
            where T : struct
                => TripleSource.index(source, dst);

        public static Triples<T> Triples<T>(this IValueSource source, Triple<T>[] dst)
            where T : struct
                => TripleSource.index(source, dst);
    }
}