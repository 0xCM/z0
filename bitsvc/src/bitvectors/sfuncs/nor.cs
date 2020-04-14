//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    using K = Kinds;

    partial class BV
    {
        [Closures(UnsignedInts)]
        public readonly struct Nor<T> : IBVBinaryOpD<T>, IBitLogicKind<K.Nor,T>
            where T : unmanaged        
        {    
            public static Nor<T> Op => default;

            public const string Name = "bvnor";

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b) => BitVector.nor(a,b);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.nor(a,b);
        }
    }
}