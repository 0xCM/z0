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
        /// Produces the next source-provided triple
        /// </summary>
        /// <param name="source">The value source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstTriple<T> NextTriple<T>(this ISource source, T t = default)
            where T : struct
                => Sources.ktriple<T>(source);

        /// <summary>
        /// Produces the next source-provided triple over a specified domain
        /// </summary>
        /// <param name="source">The value source</param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstTriple<T> NextTriple<T>(this IDomainValueSource source, T min, T max)
            where T : unmanaged
                => Sources.ktriple<T>(source, min, max);
    }
}