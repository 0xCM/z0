//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XSource
    {
        /// <summary>
        /// Produces the next triple of random primal values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstQuad<T> ConstQuad<T>(this IDataSource src)
            where T : struct
                => (src.ConstPair<T>(), src.ConstPair<T>());

        /// <summary>
        /// Produces the next triple of random primal values within a specified range
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstQuad<T> ConstQuad<T>(this IDomainSource src, T min, T max)
            where T : unmanaged
                => (src.ConstPair<T>(min,max), src.ConstPair<T>(min,max));
    }
}