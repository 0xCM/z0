//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    public static partial class BVTypes
    {
        public readonly struct Xnor<T> : IBVBinaryOpD<T>
            where T : unmanaged        
        {    
            public static Xnor<T> Op => default;

            public const string Name = "bvxnor";

            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b) => BitVector.xnor(a,b);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.xnor(a,b);
        }
    }
}