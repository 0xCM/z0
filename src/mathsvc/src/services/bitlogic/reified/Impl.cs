//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; 

    partial class MSvcHosts
    {
        [Closures(Integers), Impl]
        public readonly struct Impl<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const BitLogicKind OpKind = BitLogicKind.Impl;

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.impl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => gspan.impl(lhs,rhs,dst);
        }
    }
}