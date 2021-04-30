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
    using static ApiClassKind;

    partial struct Calcs
    {
        [MethodImpl(Inline), Factory(Srl), Closures(Closure)]
        public static Srl<T> srl<T>()
            where T : unmanaged
                => default(Srl<T>);

        [MethodImpl(Inline), Factory(Srl), Closures(Closure)]
        public static VSrl128<T> vsrl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VSrl128<T>);

        [MethodImpl(Inline), Factory(Srl), Closures(Closure)]
        public static VSrl256<T> vsrl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VSrl256<T>);

        [MethodImpl(Inline), Factory(Srl), Closures(Closure)]
        public static Srl128<T> srl<T>(W128 w)
            where T : unmanaged
                => default(Srl128<T>);

        [MethodImpl(Inline), Factory(Srl), Closures(Closure)]
        public static Srl256<T> srl<T>(W256 w)
            where T : unmanaged
                => default(Srl256<T>);

        [MethodImpl(Inline), Srl, Closures(Closure)]
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

        [MethodImpl(Inline), Srl, Closures(Closure)]
        public static ref readonly SpanBlock128<T> srl<T>(in SpanBlock128<T> a, [Imm] byte count, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref srl<T>(w128).Invoke(a, count, dst);

        [MethodImpl(Inline), Srl, Closures(Closure)]
        public static ref readonly SpanBlock256<T> srl<T>(in SpanBlock256<T> a, [Imm] byte count, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref srl<T>(w256).Invoke(a, count, dst);
    }
}