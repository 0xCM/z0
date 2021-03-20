//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BvHosts
    {
        [Closures(Closure), Add]
        public readonly struct Add<T> : IBvBinaryOp<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b)
                => BitVector.add(a,b);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b)
                => gmath.add(a,b);
        }
    }
}