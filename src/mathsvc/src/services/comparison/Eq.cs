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
        [Closures(AllNumeric), Eq]
        public readonly struct Eq<T> : IFunc<T,T,bit>, IBinarySpanPred<T>
            where T : unmanaged        
        {
            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T y) 
                => gmath.eq(x,y);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
                => apply(this, lhs,rhs,dst);
        }
    }
}