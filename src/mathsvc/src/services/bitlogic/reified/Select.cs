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
        [Closures(Integers), Select]
        public readonly struct Select<T> : ISTernaryOp<T>, ITernarySpanOp<T>
            where T : unmanaged        
        {    
            [MethodImpl(Inline)]
            public T Invoke(T a, T b, T c) 
                => gmath.select(a, b, c);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
                => gspan.select(a,b,c,dst);
        }
    }
}