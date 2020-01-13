//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static partial class BVTypes
    {
        public readonly struct And<T> : IBVBinaryOpD<T>
            where T : unmanaged        
        {    
            public static And<T> Op => default;

            public const string Name = "bvand";

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b) => BitVector.and(a,b);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.and(a,b);

        }
    }
}