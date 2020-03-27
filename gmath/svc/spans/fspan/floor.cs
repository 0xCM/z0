//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static gmath;    
    using static Checks;
        
    partial class fspan
    {                
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Span<T> floor<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var count = length(src,dst);
            for(var i =0; i<count; i++)
                dst[i] = gfp.floor(src[i]);
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Span<T> floor<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => floor(src, Spans.alloc<T>(src.Length));

       [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
       public static Span<T> floor<T>(Span<T> src)
            where T : unmanaged
        {
            for(var i =0; i<src.Length; i++)
                src[i] = gfp.floor(src[i]);
            return src;
        } 

    }
}