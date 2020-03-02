//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Root;    

    /// <summary>
    /// Implements Leimire's algorithm for sampling a uniformly distribute random number
    /// in an interval [0,..,max)
    /// </summary>
    /// <param name="random">A random source</param>
    /// <param name="max">The upper bound for the sample</param>
    /// <remarks>Reference: Fast Random Integer Generation in an Interval, Daniel Lemire 2018</remarks>
    /// <remarks>Reference: https://github.com/lemire/fastrange</reference>
    public static class Interval
    {
        /// <summary>
        /// Defines an open interval (min,max)
        /// </summary>
        /// <param name="min">The exclusive left endpoint</param>
        /// <param name="max">The exclusive right endpoint</param>
        /// <typeparam name="T">The numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Interval<T> open<T>(T min, T max)
            where T : unmanaged
                => new Interval<T>(min,max, IntervalKind.Open);

        /// <summary>
        /// Defines a closed interval [min,max]
        /// </summary>
        /// <param name="min">The inclusive left endpoint</param>
        /// <param name="max">The inclusive right endpoint</param>
        /// <typeparam name="T">The numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Interval<T> closed<T>(T min, T max)
            where T : unmanaged
                => new Interval<T>(min,max, IntervalKind.Closed);

        /// <summary>
        /// Defines an interval of specified sort
        /// </summary>
        /// <param name="min">The left endpoint</param>
        /// <param name="max">The right endpoint</param>
        /// <param name="kind">The interval kind</param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Interval<T> define<T>(T min, T max, IntervalKind kind)
            where T : unmanaged
                => new Interval<T>(min,max, kind); 
    }
}