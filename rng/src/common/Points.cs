//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class RngX
    {
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
                => src.NonZeroStream<T>((TypeMin<T>(),max)).First();

        /// <summary>
        /// Queries the source for the next nonzero value
        /// </summary>
        /// <param name="src">The random source</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static T NonZero<T>(this IPolyrand src)
            where T : unmanaged
                => src.NonZeroStream<T>((TypeMin<T>(), TypeMax<T>())).First();

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

        /// <summary>
        /// Queries the source for the next value in the range [min,max)
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
         [MethodImpl(Inline)]
         public static float Next(this IPolyrand src, float min, float max, bool truncate = false)
            => truncate ?  MathF.Floor(src.Next(min,max)) :  src.Next(min,max);

        /// <summary>
        /// Queries the source for the next value in the range [min,max)
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
         [MethodImpl(Inline)]
         public static double Next(this IPolyrand src, double min, double max, bool truncate = false)
            => truncate ?  Math.Floor(src.Next(min,max)) :  src.Next(min,max);

        /// <summary>
        /// Produces a random stream predicated on a point source
        /// </summary>
        /// <param name="random">The point source</param>
        /// <typeparam name="T">The point type</typeparam>
        public static IEnumerable<T> Stream<T>(this IRngBoundPointSource<T> random)
            where T : unmanaged
        {
            while(true)
                yield return random.Next();
        }

        /// <summary>
        /// Selects the next sequence of values from the source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of values to select</param>
        /// <typeparam name="T">The value type</typeparam>
        public static IEnumerable<T> Take<T>(this IRngBoundPointSource<T> random, int count)
            where T : unmanaged
                => random.Stream().Take(count);
    }
}