//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static SFx;

    using K = ApiClasses;

    partial struct CalcHosts
    {
        [Closures(AllNumeric), LtEq]
        public readonly struct LtEq<T> : IFunc<T,T,bit>, IBinarySpanPred<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public bit Invoke(T x, T y)
                => gmath.lteq(x,y);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<bit> dst)
                => apply(this, a,b,dst);
        }
    }
}