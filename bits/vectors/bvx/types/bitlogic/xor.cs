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
        public readonly struct Xor<T> : IBVBinaryOpD<T>
            where T : unmanaged        
        {    
            public static Xor<T> Op => default;

            public const string Name = "bvxor";

            public OpIdentity Id => OpIdentity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b) => BitVector.xor(a,b);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.xor(a,b);
        }
    }
}