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

    partial class gspan
    {
        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> srl<T>(ReadOnlySpan<T> src, byte count, Span<T> dst)
            where T : unmanaged
        {
            var len = dst.Length;
            ref readonly var input = ref first(src);
            ref var target = ref first(dst);
            for(var i = 0; i<len; i++)
                seek(target,i) = gmath.srl(skip(input,i), count);
            return dst;
        }

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> sll<T>(ReadOnlySpan<T> src, byte count, Span<T> dst)
            where T : unmanaged
        {
            var len = dst.Length;
            ref readonly var input = ref first(src);
            ref var target = ref first(dst);
            for(var i = 0; i<len; i++)
                seek(target,i) = gmath.sll(skip(input,i), count);
            return dst;
        }

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> sllv<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> counts, Span<T> dst)
            where T : unmanaged
        {
            var len = dst.Length;
            ref readonly var input = ref first(src);
            ref readonly var count = ref first(counts);
            ref var target = ref first(dst);

            for(var i=0; i < len; i++)
                seek(target,i) = gmath.sll(skip(input,i), skip(count,i));
            return dst;
        }

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> srlv<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> counts, Span<T> dst)
            where T : unmanaged
        {
            var len = dst.Length;
            ref readonly var input = ref first(src);
            ref readonly var count = ref first(counts);
            ref var target = ref first(dst);

            for(var i=0; i < len; i++)
                seek(target,i) = gmath.srl(skip(input,i), skip(count,i));
            return dst;
        }
    }
}