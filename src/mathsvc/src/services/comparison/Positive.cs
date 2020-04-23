//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed;
    using static Structured;

    partial class MSvcHosts
    {
        [Closures(AllNumeric), Positive]
        public readonly struct PositiveOp<T> : ISFunc<T,bit>, IUnarySpanPred<T>
            where T : unmanaged        
        {
            [MethodImpl(Inline)]
            public bit Invoke(T a) 
                => gmath.positive(a);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> src, Span<bit> dst)
                => apply(this, src, dst);
        }
    }
}