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
                => Sourced.triple(source, t);

        public static IEnumerable<Triple<T>> Triples<T>(this IValueSource source, T t = default)
            where T : struct
                => Sourced.triples(source, t);

        public static Triples<T> Triples<T>(this IValueSource source, int count, T t = default)
            where T : struct
                => Sourced.triples(source, count, t);

        public static Triples<T> Triples<T>(this IValueSource source, Span<Triple<T>> dst)
            where T : struct
                => Sourced.triples(source, dst);
    }
}