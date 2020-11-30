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

    partial class BV
    {
        [Closures(UnsignedInts)]
        public readonly struct Width<T> : IFunc<BitVector<T>,int>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public readonly int Invoke(BitVector<T> a) => BitVector.width(a);
        }
    }
}