//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XBitBlocks
    {
        [MethodImpl(Inline)]
        public static bit Identical<T>(this SpanBlock128<T> xb, SpanBlock128<T> yb)
            where T : unmanaged
                => xb.Storage.Identical(yb.Storage);

        [MethodImpl(Inline)]
        public static bit Identical<T>(this SpanBlock256<T> xb, SpanBlock256<T> yb)
            where T : unmanaged
                => xb.Storage.Identical(yb.Storage);
    }
}