//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static SFx;

    partial struct CalcHosts
    {
        [Closures(Integers), Even]
        public readonly struct Even<T> : IFunc<T,bit>, SFx.IUnarySpanPred<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public readonly bit Invoke(T a)
                => gmath.even(a);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(ReadOnlySpan<T> src, Span<bit> dst)
                => Calcs.even(src,dst);
        }
    }
}