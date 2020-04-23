//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed;

    using K = Kinds;

    partial class MSvcHosts
    {
        [Closures(AllNumeric)]
        public readonly struct Abs<T> : ISUnaryOp<T>, IUnarySpanOp<T>
            where T : unmanaged        
        {
            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.abs(a);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
                => gspan.inc(src,dst);
        }
    }
}