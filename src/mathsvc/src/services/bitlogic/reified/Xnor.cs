//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst; 

    partial class MSvcHosts
    {
        [Closures(Integers), Xnor]
        public readonly struct Xnor<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const BitLogicKind OpKind = BitLogicKind.Xnor;
            
            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.xnor(a, b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => gspan.nor(l,r,dst);
        }
    }
}