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
        [Closures(Integers), Nand]
        public readonly struct Nand<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.nand(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => gspan.nand(l,r,dst);
        }
    }
}