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

    public static class RngArray
    {
        /// <summary>
        /// Produces an array of random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced array</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The generated value type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Array<T>(this IPolyrand random, int length)
            where T : unmanaged
                => random.Stream<T>().TakeArray(length);

        /// <summary>
        /// Produces an array of random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced array</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The generated value type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Array<T>(this IPolyrand random, int length, Interval<T> domain)
            where T : unmanaged
                => random.Stream(domain).TakeArray(length);

        /// <summary>
        /// Produces an array of random values between specified lower and upper bounds
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced array</param>
        /// <param name="min">The inclusive minimum potential value</param>
        /// <param name="min">The exclusive maximum potential value</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The generated value type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Array<T>(this IPolyrand random, int length, T min, T max, Func<T,bool> filter)
            where T : unmanaged
                => random.Stream((min,max),filter).TakeArray(length);

        /// <summary>
        /// Produces an array of random values between specified lower and upper bounds
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced array</param>
        /// <param name="min">The inclusive minimum potential value</param>
        /// <param name="min">The exclusive maximum potential value</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The generated value type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Array<T>(this IPolyrand random, int length, T min, T max)
            where T : unmanaged
                => random.Stream(min,max).TakeArray(length);


        /// <summary>
        /// Produces an interminable stream of random bits from a value sequence of parametric type
        /// </summary>
        /// <param name="random">The random source</param>
        public static IEnumerable<bit> BitStream<T>(this IPolyrand random)
            where T : unmanaged
                => Z0.BitStream.from(random.Stream<T>());      

    }
}