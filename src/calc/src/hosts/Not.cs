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
        [Closures(Integers), Not]
        public readonly struct Not<T> : IUnaryOp<T>, IUnarySpanOp<T>
            where T : unmanaged
        {
            public const UnaryBitLogicKind OpKind = UnaryBitLogicKind.Not;

            [MethodImpl(Inline)]
            public T Invoke(T a)
                => gmath.not(a);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
                => Calcs.not(src,dst);
        }
    }
}