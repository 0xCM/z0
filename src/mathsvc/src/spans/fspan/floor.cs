//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class fspan
    {
        [MethodImpl(Inline), Floor, Closures(Floats)]
        public static Span<T> floor<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var count = math.min(src.Length, dst.Length);
            ref var output = ref first(dst);
            ref readonly var input = ref first(src);
            for(var i =0; i<count; i++)
                seek(output, i) = gfp.floor(skip(input, i));
            return dst;
        }

       [MethodImpl(Inline), Floor, Closures(Floats)]
       public static Span<T> floor<T>(Span<T> src)
            where T : unmanaged
        {
            var count = src.Length;
            ref var output = ref first(src);
            ref readonly var input = ref first(src);
            for(var i =0; i<count; i++)
                seek(output, i) = gfp.floor(skip(input, i));
            return src;
        }

        [MethodImpl(Inline)]
        public static Span<T> floor<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => floor(src, Spans.alloc<T>(src.Length));
    }
}