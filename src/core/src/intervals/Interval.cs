//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static IntervalKind;

    /// <summary>
    /// Defines interval manipulation api
    /// </summary>
    [ApiHost]
    public readonly struct Interval
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Defines an open interval (min,max)
        /// </summary>
        /// <param name="min">The exclusive left endpoint</param>
        /// <param name="max">The exclusive right endpoint</param>
        /// <typeparam name="T">The numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Interval<T> open<T>(T min, T max)
            where T : unmanaged
                => new Interval<T>(min,max, Open);

        /// <summary>
        /// Defines a closed interval [min,max]
        /// </summary>
        /// <param name="min">The inclusive left endpoint</param>
        /// <param name="max">The inclusive right endpoint</param>
        /// <typeparam name="T">The numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Interval<T> closed<T>(T min, T max)
            where T : unmanaged
                => new Interval<T>(min,max, Closed);

        /// <summary>
        /// Defines an interval of specified sort
        /// </summary>
        /// <param name="min">The left endpoint</param>
        /// <param name="max">The right endpoint</param>
        /// <param name="kind">The interval kind</param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Interval<T> define<T>(T min, T max, IntervalKind kind)
            where T : unmanaged
                => new Interval<T>(min, max, kind);
    }
}