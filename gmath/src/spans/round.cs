//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class mathspan
    {
        [MethodImpl(Inline)]
        public static Span<T> round<T>(ReadOnlySpan<T> src, int scale, Span<T> dst)
            where T : unmanaged
        {                        
            var count = length(src,dst);
            for(var i = 0; i< count; i++)
                dst[i] = gfp.round(src[i], scale);
            return dst;
        }

        public static Span<T> round<T>(ReadOnlySpan<T> src, int scale)
            where T : unmanaged
                => round(src, scale, span<T>(src.Length));
    }
}