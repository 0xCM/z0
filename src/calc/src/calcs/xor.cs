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
        public static Xor<T> xor<T>()
            where T : unmanaged
                => default(Xor<T>);

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static Xor128<T> xor<T>(W128 w)
            where T : unmanaged
                => default(Xor128<T>);

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static Xor256<T> xor<T>(W256 w)
            where T : unmanaged
                => default(Xor256<T>);

        [MethodImpl(Inline), Xor, Closures(Integers)]
        public static Span<T> xor<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(xor<T>(), a, b, dst);

        [MethodImpl(Inline), Xor, Closures(Closure)]
        public static ref readonly SpanBlock128<T> xor<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref xor<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Xor, Closures(Closure)]
        public static ref readonly SpanBlock256<T> xor<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref xor<T>(w256).Invoke(a, b, dst);
    }
}