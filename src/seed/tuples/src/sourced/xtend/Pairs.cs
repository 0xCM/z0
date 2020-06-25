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
       [MethodImpl(Inline)]
       public static Pair<T> Pair<T>(this IValueSource source, T t = default)
            where T : struct
                => PairSource.next(source,t);

        public static IEnumerable<Pair<T>> PairStream<T>(this IValueSource source, T t = default)
            where T : struct
                => PairSource.stream(source,t);

        public static Pairs<T> Pairs<T>(this IValueSource source, int count, T t = default)
            where T : struct
                => PairSource.index(source,count,t);

        public static Pairs<T> Pairs<T>(this IValueSource source, Span<Pair<T>> dst)
            where T : struct
                => PairSource.index(source, dst);

        public static Pairs<T> Pairs<T>(this IValueSource source, Pair<T>[] dst)
            where T : struct
                => PairSource.index(source, dst);
    }
}