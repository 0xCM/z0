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
        public static Pair<T> Pair<T>(this IDataSource src)
            where T : struct
                => Sources.pair<T>(src);

        public static Pairs<T> Pairs<T>(this IDataSource src, int count)
            where T : struct
                => Sources.pairs<T>(src, count);

        public static Pairs<T> Pairs<T>(this IDataSource src, Span<Pair<T>> dst)
            where T : struct
                => Sources.pairs(src, dst);

        public static Pairs<T> Pairs<T>(this IDataSource src, Pair<T>[] dst)
            where T : struct
                => Sources.pairs(src, dst);

        public static Pairs<T> Pairs<T>(this IDataSource src, uint count)
            where T : struct
                => Sources.pairs<T>(src, (int)count);

        /// <summary>
        /// Yields the next source-provided pair
        /// </summary>
        /// <param name="src">The value source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<T> ConstPair<T>(this IDataSource src)
            where T : struct
                => Sources.kpair<T>(src);

        /// <summary>
        /// Yields the next source-provided pair over a specified domain
        /// </summary>
        /// <param name="src">The value source</param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<T> ConstPair<T>(this IDomainSource src, T min, T max)
            where T : unmanaged
                => Sources.kpair(src, min, max);
    }
}