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
        [Closures(Integers), Nor]
        public readonly struct Nor<T> : ISBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.nor(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => gspan.nor(l,r,dst);
        }
    }
}