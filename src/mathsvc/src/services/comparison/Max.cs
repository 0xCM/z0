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
        [Closures(AllNumeric), Max]
        public readonly struct Max<T> : ISBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {
            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.max(a, b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => apply(this, lhs,rhs,dst);
        }
    }
}