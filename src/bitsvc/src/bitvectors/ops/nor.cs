//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class BV
    {
        [Closures(UnsignedInts), Nor]
        public readonly struct Nor<T> : IBinaryOp<T>
            where T : unmanaged        
        {    
            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b) => BitVector.nor(a,b);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) => gmath.nor(a,b);
        }
    }
}