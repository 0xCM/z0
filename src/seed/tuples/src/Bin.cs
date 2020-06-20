//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public static class Bin
    {
        [MethodImpl(Inline)]
        public static Bin<T> define<T>(in Interval<T> domain, int count)
            where T : unmanaged
                => new Bin<T>(domain, count);

        [MethodImpl(Inline)]
        public static ulong sum<T>(this ReadOnlySpan<Bin<T>> bins)
            where T : unmanaged
        {
            var sum = 0ul;
            for(var i=0; i<bins.Length; i++)            
                sum += (ulong)Root.skip(bins,i).Count;
            return sum;
        }                
    }
}