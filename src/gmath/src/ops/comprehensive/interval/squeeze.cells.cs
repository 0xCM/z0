//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static As;
    using static Konst;

    partial class gmath
    {
        [MethodImpl(Inline), Closures(UnsignedInts)]
        public static void squeeze<T>(in T src, in T max, ref T dst, uint count)
            where T : unmanaged
        {
            for(var i=0u; i<count; i++)
                seek(dst,i) = squeeze(skip(src,i), skip(max,i));
        }               

        [MethodImpl(Inline), Closures(UnsignedInts)]
        public static void squeeze<T>(ReadOnlySpan<T> src, ReadOnlySpan<T> max, Span<T> dst)
            where T : unmanaged
        {
            squeeze(first(src),first(max), ref first(dst), (uint)dst.Length);
        }               

        [MethodImpl(Inline), Closures(UnsignedInts)]
        public static Span<T> squeeze<T>(ReadOnlySpan<T> src, ReadOnlySpan<T> max)
            where T : unmanaged
        {
            var count = (uint)Root.length(src,max);
            var dst = Spans.alloc<T>(count);
            squeeze<T>(first(src), first(max), ref first(dst), count);
            return dst;
        }               
    }
}