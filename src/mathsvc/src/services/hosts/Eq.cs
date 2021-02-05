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
        [Closures(AllNumeric), Eq]
        public readonly struct Eq<T> : IFunc<T,T,bool>, SFx.IBinarySpanPred<T,bool>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public readonly bool Invoke(T x, T y)
                => gmath.eq(x,y);

            [MethodImpl(Inline)]
            public Span<bool> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
                => apply(this, lhs,rhs,dst);
        }
    }
}