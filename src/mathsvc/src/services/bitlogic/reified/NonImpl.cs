//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class MSvcHosts
    {
        [Closures(Integers), NonImpl]
        public readonly struct NonImpl<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged
        {
            public const BinaryBitLogicKind OpKind = BinaryBitLogicKind.NonImpl;

            [MethodImpl(Inline)]
            public T Invoke(T a, T b)
                => gmath.nonimpl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => gspan.nonimpl(lhs,rhs,dst);
        }
    }
}