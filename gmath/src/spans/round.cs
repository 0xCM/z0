//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        public static Span<T> round<T>(ReadOnlySpan<T> src, int scale, Span<T> dst)
            where T : unmanaged
        {                        
            for(var i = 0; i< src.Length; i++)
                dst[i] = gfp.round(src[i], scale);
            return dst;
        }

        public static Span<T> round<T>(ReadOnlySpan<T> src, int scale)
            where T : unmanaged
                => round(src, scale, span<T>(src.Length));


        public static Span<T> round<T>(Span<T> src, int scale)
            where T : unmanaged
        {         
            for(var i = 0; i< src.Length; i++)
                src[i] = gfp.round(src[i], scale);
            return src;
        }
    }
}