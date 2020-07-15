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
        /// <summary>
        /// Yields the next source-provided pair
        /// </summary>
        /// <param name="source">The value source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<T> NextPair<T>(this IValueSource source, T t = default)
            where T : struct
                => PairSource.constant(source,t);

        /// <summary>
        /// Yields the next source-provided pair over a specified domain
        /// </summary>
        /// <param name="source">The value source</param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<T> NextPair<T>(this IBoundValueSource source, T min, T max)
            where T : struct
                => PairSource.constant(source, min, max);
    }
}