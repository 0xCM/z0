//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
     
    [ApiHost("api")]
    public static partial class Blocks
    {

    }

    public static partial class XBlocks    
    {
    
    }    

    public static partial class XTend
    {
        public static NatSpan<N,T> Squeeze<N,T>(this NatSpan<N,T> src, NatSpan<N,T> max)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dst = NatSpan.alloc<N, T>();
            for(var i=0; i<dst.Length; i++)
                dst[i] = gmath.squeeze(src[i],max[i]);
            return dst;
        }

        
    }
}