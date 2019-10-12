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
            var len = length(src,dst);
            for(var i =0; i<len; i++)
                dst[i] = gfp.floor(src[i]);
            return dst;
        }

        public static Span<T> floor<T>(ReadOnlySpan<T> src)
            where T : unmanaged
            => floor(src, src.Replicate(true));

        public static Span<T> floor<T>(Span<T> io)
            where T : unmanaged
        {
            for(var i =0; i<io.Length; i++)
                io[i] = gfp.floor(io[i]);
            return  io;
        } 
    }
}