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
        public readonly struct Nand<T> : IBVBinaryOpD<T>, IBitLogicKind<K.Nand>
            where T : unmanaged        
        {    
            public static Nand<T> Op => default;

            public const string Name = "bvnand";

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b) => BitVector.nand(a,b);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.nand(a,b);

        }
    }
}