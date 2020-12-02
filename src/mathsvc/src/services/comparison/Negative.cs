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
        [Closures(AllNumeric), Negative]
        public readonly struct NegativeOp<T> : IFunc<T,bit>, SFx.IUnarySpanPred<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public bit Invoke(T a)
                => gmath.negative(a);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> src, Span<bit> dst)
                => apply(this, src, dst);
        }
    }
}