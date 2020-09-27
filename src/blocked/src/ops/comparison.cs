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

    partial class Blocked
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly SpanBlock128<T> gt<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.gt<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly SpanBlock256<T> gt<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.gt<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<Bit32> nonz<T>(in SpanBlock128<T> a, Span<Bit32> dst)
            where T : unmanaged
                => BSvc.nonz<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<Bit32> nonz<T>(in SpanBlock256<T> a, Span<Bit32> dst)
            where T : unmanaged
                => BSvc.nonz<T>(w256).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<Bit32> testc<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, Span<Bit32> dst)
            where T : unmanaged
                => BSvc.testc<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<Bit32> testc<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, Span<Bit32> dst)
            where T : unmanaged
                => BSvc.testc<T>(w256).Invoke(a, b, dst);
    }
}