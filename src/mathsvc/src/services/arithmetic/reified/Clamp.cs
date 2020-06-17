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
        [Closures(AllNumeric), Clamp]
        public readonly struct Clamp<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {
            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.clamp(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => gspan.clamp(l,r,dst);
        }
    }
}