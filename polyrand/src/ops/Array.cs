//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class Polyfun
    {        
        /// <summary>
        /// Produces the next pair of random primal values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<T> NextPair<T>(this IPolyrand random, T t = default)
            where T : unmanaged
                => (random.Next<T>(), random.Next<T>());

        /// <summary>
        /// Produces the next pair of random primal values within a specified range
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<T> NextPair<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
                => (random.Next<T>(min,max), random.Next<T>(min,max));

        /// <summary>
        /// Produces the next triple of random primal values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstTriple<T> NextTriple<T>(this IPolyrand random, T t = default)
            where T : unmanaged
                => (random.Next<T>(), random.Next<T>(),random.Next<T>());

        /// <summary>
        /// Produces the next triple of random primal values within a specified range
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstTriple<T> NextTriple<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
                => (random.Next<T>(min,max), random.Next<T>(min,max),random.Next<T>(min,max));

        /// <summary>
        /// Produces the next triple of random primal values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="a">The first element in the pair</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstQuad<T> NextQuad<T>(this IPolyrand random, T t = default)
            where T : unmanaged
                => (random.NextPair<T>(), random.NextPair<T>());

        /// <summary>
        /// Produces the next triple of random primal values within a specified range
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The inclusive minimum value</param>
        /// <param name="max">The exclusive maximum value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ConstQuad<T> NextQuad<T>(this IPolyrand random, T min, T max)
            where T : unmanaged
                => (random.NextPair<T>(min,max), random.NextPair<T>(min,max));
         
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

    }
}