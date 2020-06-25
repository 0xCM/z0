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
        /// <summary>
        /// Produces the next triple of random primal values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstQuad<T> NextQuad<T>(this IValueSource random, T t = default)
            where T : struct
                => (random.NextPair<T>(), random.NextPair<T>());

        /// <summary>
        /// Produces the next triple of random primal values within a specified range
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstQuad<T> NextQuad<T>(this IBoundValueSource random, T min, T max)
            where T : struct
                => (random.NextPair<T>(min,max), random.NextPair<T>(min,max));
    }
}