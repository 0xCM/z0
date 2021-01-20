//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XSource
    {
        public static Triples<T> Triples<T>(this IDataSource src, int count, T t = default)
            where T : struct
                => Sources.triples(src, count, t);

        public static Triples<T> Triples<T>(this IDataSource src, Span<Triple<T>> dst)
            where T : struct
                => Sources.triples(src, dst);
    }
}