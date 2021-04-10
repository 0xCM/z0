//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;

    partial class MSvcHosts
    {
        [Closures(Integers), Impl]
        public readonly struct Impl<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged
        {
            public const BinaryBitLogicKind OpKind = BinaryBitLogicKind.Impl;

            [MethodImpl(Inline)]
            public T Invoke(T a, T b)
                => gmath.impl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
                => gspan.impl(a,b,dst);
        }
    }
}