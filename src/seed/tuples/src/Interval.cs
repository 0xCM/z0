//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static IntervalKind;

    /// <summary>
    /// Defines interval manipulation api
    /// </summary>
    [ApiHost]
    public readonly struct Interval
    {
        /// <summary>
        /// Defines an open interval (min,max)
        /// </summary>
        /// <param name="min">The exclusive left endpoint</param>
        /// <param name="max">The exclusive right endpoint</param>
        /// <typeparam name="T">The numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Interval<T> open<T>(T min, T max)
            where T : unmanaged
                => new Interval<T>(min,max, Open);

        /// <summary>
        /// Defines a closed interval [min,max]
        /// </summary>
        /// <param name="min">The inclusive left endpoint</param>
        /// <param name="max">The inclusive right endpoint</param>
        /// <typeparam name="T">The numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Interval<T> closed<T>(T min, T max)
            where T : unmanaged
                => new Interval<T>(min,max, Closed);

        /// <summary>
        /// Constructs the (left-closed | right-open) interval [min,max)
        /// </summary>
        /// <param name="min">The inclusive left endpoint</param>
        /// <param name="max">The exclusive right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Interval<T> closedL<T>(T min, T max)
            where T : unmanaged
                => Interval.define(min,max, LeftClosed);

        /// <summary>
        /// Constructs the (left-closed | right-open) interval [min,max)
        /// </summary>
        /// <param name="min">The inclusive left endpoint</param>
        /// <param name="max">The exclusive right endpoint</param>
        /// <typeparam name="T">The underlying type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Interval<T> closedR<T>(T min, T max)
            where T : unmanaged
                => Interval.define(min,max, RightClosed);

        /// <summary>
        /// Defines an interval of specified sort
        /// </summary>
        /// <param name="min">The left endpoint</param>
        /// <param name="max">The right endpoint</param>
        /// <param name="kind">The interval kind</param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Interval<T> define<T>(T min, T max, IntervalKind kind)
            where T : unmanaged
                => new Interval<T>(min, max, kind); 
    }
}