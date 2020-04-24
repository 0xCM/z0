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
        [Closures(UnsignedInts), Not]
        public readonly struct Not<T> : IUnaryOp<T>
            where T : unmanaged        
        {    
            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a) => BitVector.not(a);

            [MethodImpl(Inline)]
            public T Invoke(T a) => gmath.not(a);
        }
    }
}