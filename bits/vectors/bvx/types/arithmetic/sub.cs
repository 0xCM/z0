//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static partial class BVTypes
    {
        public readonly struct Sub<T> : IBVBinaryOpD<T>
            where T : unmanaged        
        {    
            public static Sub<T> Op => default;

            public const string Name = "bvsub";

            public OpIdentity Id => OpIdentity.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b) => BitVector.sub(a,b);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.sub(a,b);

        }
    }
}