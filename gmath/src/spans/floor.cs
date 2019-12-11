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
        public static Span<T> floor<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var count = length(src,dst);
            for(var i =0; i<count; i++)
                dst[i] = gfp.floor(src[i]);
            return dst;
        }

        public static Span<T> floor<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => floor(src, span<T>(src.Length));

        public static Span<T> floor<T>(Span<T> src)
            where T : unmanaged
        {
            for(var i =0; i<src.Length; i++)
                src[i] = gfp.floor(src[i]);
            return src;
        } 
    }
}