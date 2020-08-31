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
        [MethodImpl(Inline), Select, Closures(Integers)]
        public static ref readonly SpanBlock128<T> select<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> c, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.select<T>(w128).Invoke(a, b, c, dst);

        [MethodImpl(Inline), Select, Closures(Integers)]
        public static ref readonly SpanBlock256<T> select<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> c, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.select<T>(w256).Invoke(a, b, c, dst);
    }
}