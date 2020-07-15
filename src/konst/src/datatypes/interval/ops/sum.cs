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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ulong sum<T>(ReadOnlySpan<Bin<T>> bins)
            where T : unmanaged
        {
            var sum = 0ul;
            var count = bins.Length;
            for(var i=0u; i<count; i++)            
                sum += skip(bins,i).Count;
            return sum;
        } 
    }
}