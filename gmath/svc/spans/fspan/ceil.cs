//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    
    using static As;
    using static Checks;
        
    partial class fspan
    {                
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Span<T> ceil<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var len = length(src,dst);
            for(var i =0; i<len; i++)
                dst[i] = gfp.ceil(src[i]);
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Span<T> ceil<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ceil(src, Spans.alloc<T>(src.Length));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Span<T> ceil<T>(Span<T> io)
            where T : unmanaged
        {
            for(var i =0; i<io.Length; i++)
                io[i] = gfp.ceil(io[i]);
            return io;
        }

    }
}