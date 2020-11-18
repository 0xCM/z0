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
        /// Creates a bin over a closed interval partitioned into a specified number of segments
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="count">The partition count</param>
        /// <typeparam name="T">The interval domain</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Bin<T> bin<T>(in ClosedInterval<T> src, uint count)
            where T : unmanaged
                => new Bin<T>(src, count);
    }
}