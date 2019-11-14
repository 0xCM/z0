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

        public static Span<T> ceil<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var len = length(src,dst);
            for(var i =0; i<len; i++)
                dst[i] = gfp.ceil(src[i]);
            return dst;
        }

        public static Span<T> ceil<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ceil(src, span<T>(src.Length));

        public static Span<T> ceil<T>(Span<T> io)
            where T : unmanaged
        {
            for(var i =0; i<io.Length; i++)
                io[i] = gfp.ceil(io[i]);
            return io;
        }

    }

}