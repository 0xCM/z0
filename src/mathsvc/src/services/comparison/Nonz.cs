//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static SFx;

    partial class MSvcHosts
    {
        [Closures(AllNumeric), Nonz]
        public readonly struct Nonz<T> : IFunc<T,Bit32>, IUnarySpanPred<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Bit32 Invoke(T a)
                => gmath.nonz(a);

            [MethodImpl(Inline)]
            public Span<Bit32> Invoke(ReadOnlySpan<T> src, Span<Bit32> dst)
                => apply(this, src, dst);
        }
    }
}