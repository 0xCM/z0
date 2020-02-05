//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static partial class BVTypes
    {
        public readonly struct Nand<T> : IBVBinaryOpD<T>
            where T : unmanaged        
        {    
            public static Nand<T> Op => default;

            public const string Name = "bvnand";

            public OpIdentity Moniker => Identity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b) => BitVector.nand(a,b);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.nand(a,b);

        }
    }
}