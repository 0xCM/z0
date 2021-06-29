//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct gAlg
    {
        /// <summary>
        /// Findes the number of items in an index-identified bucket
        /// </summary>
        /// <param name="src">The histogram to query</param>
        /// <param name="index">THe bucket index</param>
        /// <typeparam name="T">The point domain</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint count<T>(in Histogram<T> src, uint index)
            where T : unmanaged, IComparable<T>
                => (uint)src.Counts[index-1];
    }
}