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

    partial class BC
    {
        [Closures(AllNumeric)]
        public readonly struct Between<T> : IUnaryImm8x2Op<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public T Invoke(T a, byte k1, byte k2)
                => gbits.segment(a,k1,k2);
        }
    }
}