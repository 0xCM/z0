//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BV
    {
        [Closures(UnsignedInts), Dot]
        public readonly struct Dot<T> : IBvBinaryPred<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public readonly Bit32 Invoke(BitVector<T> a, BitVector<T> b) => BitVector.dot(a,b);

            [MethodImpl(Inline)]
            public Bit32 Invoke(T a, T b) => gbits.dot(a,b);
        }
    }
}