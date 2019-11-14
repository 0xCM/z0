//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class mathspan
    {
        public static Span<T> fabs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var len = length(src,dst);
            for(var i=0; i< len; i++)
                dst[i] = gfp.abs(src[i]);
            return dst;
        }

        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var len = length(src,dst);
            for(var i=0; i< len; i++)
                dst[i] = gmath.abs(src[i]);
            return dst;
        }
    }
}