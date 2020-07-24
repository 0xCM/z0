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
        /// Presents an index-identifeid histogram bucket as an interval
        /// </summary>
        /// <param name="src">The histogram to search</param>
        /// <param name="index">THe bucket index</param>
        /// <typeparam name="T">The point domain</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ClosedInterval<T> segment<T>(in Histogram<T> src, uint index)
            where T : unmanaged
                => closed(point(src, index-1), point(src, index)); 

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        static ClosedInterval<T> segment<T>(in T src, uint index)
            where T : unmanaged
                => closed(point(src, index-1), point(src, index)); 
    }
}