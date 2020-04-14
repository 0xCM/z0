//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; 
    using static Memories;

    using K = Kinds;

    partial class BV
    {
        [Closures(UnsignedInts)]
        public readonly struct Dot<T> : IBVBinaryPredD<T>
            where T : unmanaged        
        {    
            public static Dot<T> Op => default;

            public const string Name = "bvdot";

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(BitVector<T> a, BitVector<T> b) => BitVector.dot(a,b);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a, T b) => gbits.dot(a,b);
        }
    }
}