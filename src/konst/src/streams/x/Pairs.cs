//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        public static Pair<T> Pair<T>(this IValueSource source, T t = default)
            where T : struct
                => Sources.pair(source,t);

        public static Pairs<T> Pairs<T>(this IValueSource source, int count, T t = default)
            where T : struct
                => Sources.pairs(source,count,t);

        public static Pairs<T> Pairs<T>(this IValueSource source, Span<Pair<T>> dst)
            where T : struct
                => Sources.pairs(source, dst);

        public static Pairs<T> Pairs<T>(this IValueSource source, Pair<T>[] dst)
            where T : struct
                => Sources.pairs(source, dst);

        public static Pairs<T> Pairs<T>(this IValueSource source, uint count, T t = default)
            where T : struct
                => Sources.pairs(source, (int)count,t);
    }
}