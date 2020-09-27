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
        [Closures(Integers), Odd]
        public readonly struct Odd<T> : IFunc<T,Bit32>, IUnarySpanPred<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public readonly Bit32 Invoke(T a) => gmath.odd(a);

            [MethodImpl(Inline)]
            public Span<Bit32> Invoke(ReadOnlySpan<T> src, Span<Bit32> dst)
                => gspan.odd(src,dst);
        }
    }
}