//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static partial class BVTypes
    {
        public readonly struct Not<T> : IBVUnaryOpD<T>
            where T : unmanaged        
        {    
            public static Not<T> Op => default;

            public const string Name = "bvnot";

            public OpIdentity Id => Identity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a) => BitVector.not(a);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gmath.not(a);

        }
    }
}