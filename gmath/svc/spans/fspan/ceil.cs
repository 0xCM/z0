//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; using static Memories;    
        
    partial class fspan
    {                
        [MethodImpl(Inline), Op, Closures(NumericKind.Floats)]
        public static Span<T> ceil<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var count = math.min(src.Length, dst.Length);
            ref var output = ref head(dst);
            ref readonly var input = ref head(src);
            for(var i =0; i<count; i++)
                seek(ref output, i) = gfp.ceil(skip(input, i));
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(NumericKind.Floats)]
        public static Span<T> ceil<T>(Span<T> src)
            where T : unmanaged
        {
            var count = src.Length;
            ref var a = ref head(src);
            ref readonly var b = ref head(src);
            for(var i =0; i<count; i++)
                seek(ref a, i) = gfp.ceil(skip(b, i));
            return src;
        }

        [MethodImpl(Inline), Op, Closures(NumericKind.Floats)]
        public static Span<T> ceil<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ceil(src, Spans.alloc<T>(src.Length));
    }
}