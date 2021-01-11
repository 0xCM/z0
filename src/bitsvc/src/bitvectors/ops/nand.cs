//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BV
    {
        [Closures(UnsignedInts)]
        public readonly struct Nand<T> : IBvBinaryOp<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b) => BitVector.nand(a,b);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) => gmath.nand(a,b);
        }
    }
}