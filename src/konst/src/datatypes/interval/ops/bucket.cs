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
        /// Searches for the bucket containing the point; if found, returns the bucket index; otherwise returns a failure code
        /// </summary>
        /// <param name="src">The histogram to search</param>
        /// <param name="point">A point contained in some bucket, hopefully </param>
        /// <typeparam name="T">The point domain</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static uint bucket<T>(in Histogram<T> src, T point)
            where T : unmanaged
        {
            var partitions = src.Partitions.Length;            
            for(var i = 1u; i<partitions; i++)                    
                if(contains(segment(src, i),point))
                    return i;
            return uint.MaxValue;
        }

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        static uint bucket<T>(in T src, uint partCount, T point)
            where T : unmanaged
        {                     
            for(var i = 1u; i<partCount; i++)                    
                if(contains(segment(src, i),point))
                    return i;
            return uint.MaxValue;
        }
    }
}