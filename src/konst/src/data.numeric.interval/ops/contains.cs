//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;

    partial struct Intervals
    {
        /// <summary>
        /// Determines whether the source interval contains a specified test point
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="x">The point to test</param>
        /// <typeparam name="T">The interval domain</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bool contains<T>(in ClosedInterval<T> src, T x)
            where T : unmanaged
                => between(uint64(x), left(src), right(src));
    }
}