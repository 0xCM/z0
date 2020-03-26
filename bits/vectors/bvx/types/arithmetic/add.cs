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
        public readonly struct Add<T> : IBVBinaryOpD<T>
            where T : unmanaged        
        {    
            public static Add<T> Op => default;

            public const string Name = "bvadd";

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b) => BitVector.add(a,b);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.add(a,b);
        }
    }
}