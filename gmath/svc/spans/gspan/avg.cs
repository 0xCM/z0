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

    partial class gspan
    {
        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.All)]
        public static T avg<T>(ReadOnlySpan<T> src, bool @checked)
            where T : unmanaged
                => avg_u(src,@checked);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.All)]
        public static T avg<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => avg_u(src,true);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.All)]
        public static T avg<T>(Span<T> src, bool @checked)
            where T : unmanaged
                => avg(src.ReadOnly(), @checked);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.All)]
        public static T avg<T>(Span<T> src)
            where T : unmanaged
                => avg(src.ReadOnly(), true);

        [MethodImpl(Inline)]
        public static T avgz<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            ref readonly var reader = ref head(src);
            T result = reader;
            for(var i=1; i<src.Length; i++)
                result = gmath.avgz(result, skip(in reader, i));
            return result;
        }

        [MethodImpl(Inline)]
        public static T avgz<T>(Span<T> src)
            where T : unmanaged
                => avgz(src.ReadOnly());

        [MethodImpl(Inline)]
        static T avg_u<T>(ReadOnlySpan<T> src, bool @checked)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.avg(Spans.s8u(src), @checked));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.avg(Spans.s16u(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.avg(Spans.s32u(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.avg(Spans.s64u(src)));
            else
                return avg_i(src, @checked);
        }           

        [MethodImpl(Inline)]
        static T avg_i<T>(ReadOnlySpan<T> src, bool @checked)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.avg(Spans.s8i(src), @checked));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.avg(Spans.s16i(src), @checked));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.avg(Spans.s32i(src), @checked));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.avg(Spans.s64i(src), @checked));
            else
                return fspan.avg(src, @checked);
        }           

    }
}