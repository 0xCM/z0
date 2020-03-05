//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    partial class CoreRngOps
    {
        /// <summary>
        /// Produces a stream of nonzero uniformly random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IRngStream<T> NonZeroStream<T>(this IPolyrand random, Interval<T> domain)
            where T : unmanaged
                => CoreRng.stream(random.UniformStream(domain, x => gmath.nonz(x)), random.RngKind);

        /// <summary>
        /// Queries the source for the next nonzero value within a range
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static T NonZero<T>(this IPolyrand src, T min, T max)
            where T : unmanaged
                => src.NonZeroStream<T>((min,max)).First();

        /// <summary>
        /// Queries the source for the next nonzero value less than a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="max">The exclusive uper bound</param>
        [MethodImpl(Inline)]
        public static T NonZero<T>(this IPolyrand src, T max)
            where T : unmanaged
                => src.NonZeroStream<T>((minval<T>(),max)).First();

        /// <summary>
        /// Queries the source for the next nonzero value
        /// </summary>
        /// <param name="src">The random source</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static T NonZero<T>(this IPolyrand src)
            where T : unmanaged
                => src.NonZeroStream<T>((minval<T>(), maxval<T>())).First();

        /// <summary>
        /// Queries the source for the next nonzero value within a range
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The range of potential values</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static T NonZero<T>(this IPolyrand src, Interval<T> domain)
            where T : unmanaged
                => src.NonZeroStream<T>(domain).First();
    }
}