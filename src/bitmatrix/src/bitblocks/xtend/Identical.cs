//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Memories;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static bit Identical<T>(this SpanBlock128<T> xb, SpanBlock128<T> yb)
            where T : unmanaged
                => xb.Data.Identical(yb.Data);

        [MethodImpl(Inline)]
        public static bit Identical<T>(this SpanBlock256<T> xb, SpanBlock256<T> yb)
            where T : unmanaged
                => xb.Data.Identical(yb.Data);
    }
}