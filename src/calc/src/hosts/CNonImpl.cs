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

    partial struct CalcHosts
    {
        [Closures(Integers), CNonImpl]
        public readonly struct CNonImpl<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged
        {
            public const BinaryBitLogicKind OpKind = BinaryBitLogicKind.CNonImpl;

            [MethodImpl(Inline)]
            public T Invoke(T a, T b)
                => gmath.cnonimpl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => Calcs.cnonimpl(lhs,rhs,dst);
        }

        [Closures(Integers), CNonImpl]
        public readonly struct CNonImpl128<T> : IBlockedBinaryOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock128<T> Invoke(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
                => ref zip(a, b, dst, VSvc.vcnonimpl<T>(w128));
        }

        [Closures(Integers), CNonImpl]
        public readonly struct CNonImpl256<T> : IBlockedBinaryOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock256<T> Invoke(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
                => ref zip(a, b, dst, VSvc.vcnonimpl<T>(w256));
        }

    }
}