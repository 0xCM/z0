//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Intervals
    {
        /// <summary>
        /// Defines a closed interval
        /// </summary>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The inclusive upper bound</param>
        /// <typeparam name="T">The interval domain</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ClosedInterval<T> closed<T>(T min, T max)
            where T : unmanaged
                => new ClosedInterval<T>(min,max);
    }
}