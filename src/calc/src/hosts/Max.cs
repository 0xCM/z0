//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;

    partial struct CalcHosts
    {
        [Closures(AllNumeric), Max]
        public readonly struct Max<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public T Invoke(T a, T b)
                => gmath.max(a, b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
                => apply(this, a,b,dst);
        }
    }
}