//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CalcHosts;
    using static memory;
    using static SFx;

    partial struct Calcs
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Sll<T> sll<T>()
            where T : unmanaged
                => default(Sll<T>);

        [MethodImpl(Inline), Sll, Closures(Integers)]
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

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock128<T> sll<T>(in SpanBlock128<T> a, [Imm] byte count, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.sll<T>(w128).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock256<T> sll<T>(in SpanBlock256<T> a, [Imm] byte count, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.sll<T>(w256).Invoke(a, count, dst);

    }
}