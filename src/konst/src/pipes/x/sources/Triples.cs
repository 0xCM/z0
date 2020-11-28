//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XSource
    {
        public static Triples<T> Triples<T>(this ISource source, int count, T t = default)
            where T : struct
                => Sources.triples(source, count, t);

        public static Triples<T> Triples<T>(this ISource source, Span<Triple<T>> dst)
            where T : struct
                => Sources.triples(source, dst);
    }
}