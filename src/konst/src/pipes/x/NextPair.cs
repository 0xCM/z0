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
        /// <summary>
        /// Yields the next source-provided pair
        /// </summary>
        /// <param name="source">The value source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<T> NextPair<T>(this ISource source, T t = default)
            where T : struct
                => Sources.kpair(source,t);

        /// <summary>
        /// Yields the next source-provided pair over a specified domain
        /// </summary>
        /// <param name="source">The value source</param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<T> NextPair<T>(this IDomainValueSource source, T min, T max)
            where T : unmanaged
                => Sources.kpair(source, min, max);
    }
}