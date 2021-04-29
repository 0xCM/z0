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
        [Closures(Integers), Select]
        public readonly struct Select<T> : ITernaryOp<T>, ITernarySpanOp<T>
            where T : unmanaged
        {
            public const TernaryBitLogicKind OpKind = TernaryBitLogicKind.XCA;

            [MethodImpl(Inline)]
            public T Invoke(T a, T b, T c)
                => gmath.select(a, b, c);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
                => Calcs.select(a,b,c,dst);
        }
    }
}