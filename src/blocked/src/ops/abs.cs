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
        [MethodImpl(Inline), Op, Closures(SignedInts)]
        public static ref readonly SpanBlock128<T> abs<T>(in SpanBlock128<T> a, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.abs<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Op, Closures(SignedInts)]
        public static ref readonly SpanBlock256<T> abs<T>(in SpanBlock256<T> a, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.abs<T>(w256).Invoke(a, dst);
    }
}