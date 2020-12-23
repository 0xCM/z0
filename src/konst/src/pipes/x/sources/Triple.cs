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
        public static Triple<T> Triple<T>(this IDataSource src)
            where T : struct
                => Sources.triple<T>(src);

        /// <summary>
        /// Produces the next source-provided triple
        /// </summary>
        /// <param name="src">The value source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstTriple<T> ConstTriple<T>(this IDataSource src)
            where T : struct
                => Sources.ktriple<T>(src);

        /// <summary>
        /// Produces the next source-provided triple over a specified domain
        /// </summary>
        /// <param name="src">The value source</param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstTriple<T> ConstTriple<T>(this IDomainSource src, T min, T max)
            where T : unmanaged
                => Sources.ktriple<T>(src, min, max);
    }
}