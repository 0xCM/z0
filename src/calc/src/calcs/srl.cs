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
        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static Srl<T> srl<T>()
            where T : unmanaged
                => default(Srl<T>);

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static Srl128<T> srl<T>(W128 w)
            where T : unmanaged
                => default(Srl128<T>);

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static Srl256<T> srl<T>(W256 w)
            where T : unmanaged
                => default(Srl256<T>);

        [MethodImpl(Inline), Srl, Closures(Integers)]
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

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock128<T> srl<T>(in SpanBlock128<T> a, [Imm] byte count, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref srl<T>(w128).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock256<T> srl<T>(in SpanBlock256<T> a, [Imm] byte count, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref srl<T>(w256).Invoke(a, count, dst);
    }
}