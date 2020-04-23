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
        [Closures(AllNumeric), GtEq]
        public readonly struct GtEq<T> : ISFunc<T,T,bit>, IBinarySpanPred<T>
            where T : unmanaged        
        {
            [MethodImpl(Inline)]
            public bit Invoke(T a, T b) 
                => gmath.gteq(a,b);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
                => apply(this, lhs,rhs,dst);
        }
    }
}