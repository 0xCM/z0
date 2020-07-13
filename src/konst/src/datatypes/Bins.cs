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

    public readonly struct Bins
    {
        [MethodImpl(Inline)]
        public static ulong sum<T>(ReadOnlySpan<Bin<T>> bins)
            where T : unmanaged
        {
            var sum = 0ul;
            for(var i=0u; i<bins.Length; i++)            
                sum += (ulong)z.skip(bins,i).Count;
            return sum;
        }                
    }
}