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
        [Closures(UnsignedInts), And]
        public readonly struct And<T> : IBvBinaryOp<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b) => BitVector.and(a,b);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) => gmath.and(a,b);
        }
    }
}