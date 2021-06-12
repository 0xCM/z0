//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Intervals
    {
        /// <summary>
        /// Defines an open interval (min,max)
        /// </summary>
        /// <param name="min">The exclusive left endpoint</param>
        /// <param name="max">The exclusive right endpoint</param>
        /// <typeparam name="T">The numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Interval<T> open<T>(T min, T max)
            where T : unmanaged
                => new Interval<T>(min,max, IntervalKind.Open);
    }
}