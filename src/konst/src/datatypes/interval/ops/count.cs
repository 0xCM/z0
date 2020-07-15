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
        /// Findes the number of items in an index-identified bucket
        /// </summary>
        /// <param name="src">The histogram to query</param>
        /// <param name="index">THe bucket index</param>
        /// <typeparam name="T">The point domain</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static uint count<T>(in Histogram<T> src, uint index)
            where T : unmanaged
                => (uint)src.Counts[index-1];
    }
}