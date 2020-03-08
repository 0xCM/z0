//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;

    partial class BitCoreServices
    {
        public readonly struct Bfly<N,T> : INaturalUnaryOp<N,T>
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            public const string Name = "bfly";

            public static Bfly<N,T> Op => default;

            public OpIdentity Id => NaturalIdentity.contracted<N,T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a) => gbits.bfly<N,T>(a);
        }
    }
}