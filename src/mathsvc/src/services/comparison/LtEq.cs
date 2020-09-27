//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static SFx;

    partial class MSvcHosts
    {
        [Closures(AllNumeric), LtEq]
        public readonly struct LtEq<T> : IFunc<T,T,Bit32>, IBinarySpanPred<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Bit32 Invoke(T x, T y)
                => gmath.lteq(x,y);

            [MethodImpl(Inline)]
            public Span<Bit32> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<Bit32> dst)
                => apply(this, lhs,rhs,dst);
        }
    }
}