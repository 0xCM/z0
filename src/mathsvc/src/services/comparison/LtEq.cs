//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static Structured;

    partial class MSvcHosts
    {
        [Closures(AllNumeric), LtEq]
        public readonly struct LtEq<T> : IFunc<T,T,bit>, IBinarySpanPred<T>
            where T : unmanaged        
        {
            [MethodImpl(Inline)]
            public bit Invoke(T x, T y) 
                => gmath.lteq(x,y);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
                => apply(this, lhs,rhs,dst);
        }
    }
}