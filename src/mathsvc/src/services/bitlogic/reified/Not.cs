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
        [Closures(Integers), Not]
        public readonly struct Not<T> : ISUnaryOp<T>, IUnarySpanOp<T>
            where T : unmanaged        
        {            
            [MethodImpl(Inline)]
            public T Invoke(T a) 
                => gmath.not(a);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
                => gspan.not(src,dst);
        }    
    }
}