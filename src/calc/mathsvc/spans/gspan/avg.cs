//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class gspan
    {
        [MethodImpl(Inline), SpanOp, Closures(AllNumeric)]
        public static T avg<T>(ReadOnlySpan<T> src, bool @checked)
            where T : unmanaged
                => avg_u(src,@checked);

        [MethodImpl(Inline), SpanOp, Closures(AllNumeric)]
        public static T avg<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => avg_u(src,true);

        [MethodImpl(Inline), SpanOp, Closures(AllNumeric)]
        public static T avg<T>(Span<T> src, bool @checked)
            where T : unmanaged
                => avg(src.ReadOnly(), @checked);

        [MethodImpl(Inline), SpanOp, Closures(AllNumeric)]
        public static T avg<T>(Span<T> src)
            where T : unmanaged
                => avg(src.ReadOnly(), true);

        [MethodImpl(Inline)]
        public static T avgz<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            ref readonly var a = ref first(src);
            var result = a;
            for(var i=1; i<src.Length; i++)
                result = gmath.avgz(result, skip(a, i));
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
                return generic<T>(mspan.avg(memory.uint8(src), @checked));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(mspan.avg(memory.uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(mspan.avg(memory.uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(mspan.avg(memory.uint64(src)));
            else
                return avg_i(src, @checked);
        }

        [MethodImpl(Inline)]
        static T avg_i<T>(ReadOnlySpan<T> src, bool @checked)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(mspan.avg(memory.int8(src), @checked));
            else if(typeof(T) == typeof(short))
                return generic<T>(mspan.avg(memory.int16(src), @checked));
            else if(typeof(T) == typeof(int))
                return generic<T>(mspan.avg(memory.int32(src), @checked));
            else if(typeof(T) == typeof(long))
                return generic<T>(mspan.avg(memory.int64(src), @checked));
            else
                return fspan.avg(src, @checked);
        }
    }
}