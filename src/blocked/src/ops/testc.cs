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
        public static Span<Bit32> testz<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, Span<Bit32> dst)
            where T : unmanaged
                => BSvc.testz<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Span<Bit32> testz<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, Span<Bit32> dst)
            where T : unmanaged
                => BSvc.testz<T>(w256).Invoke(a, b, dst);
    }
}