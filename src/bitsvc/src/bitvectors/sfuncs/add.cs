//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; 

    using K = Kinds;

    partial class BV
    {
        [Closures(UnsignedInts)]
        public readonly struct Add<T> : IBVBinaryOpD<T>, IArithmeticKind<K.Add,T>
            where T : unmanaged        
        {    
            public static Add<T> Op => default;

            public const string Name = "bvadd";

            public OpIdentity Id => Identities.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b) => BitVector.add(a,b);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.add(a,b);
        }
    }
}