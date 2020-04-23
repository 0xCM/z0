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
        [Closures(AllNumeric)]
        public readonly struct Negate<T> : ISUnaryOp<T>, IUnarySpanOp<T>
            where T : unmanaged        
        {
            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.negate(a);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
                => gspan.negate(src,dst);
        }
    }
}