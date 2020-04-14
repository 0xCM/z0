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
        public readonly struct And<T> : IBVBinaryOpD<T>, IBitLogicKind<K.And>
            where T : unmanaged        
        {    
            public static And<T> Op => default;

            public const string Name = "bvand";

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b) => BitVector.and(a,b);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.and(a,b);
        }
    }
}