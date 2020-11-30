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
        [Closures(UnsignedInts), Sub]
        public readonly struct Sub<T> : IBvBinaryOp<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b) => BitVector.sub(a,b);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) => gmath.sub(a,b);
        }
    }
}