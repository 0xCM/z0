//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static SFx;
    using K = ApiClasses;

    partial struct CalcHosts
    {
        public readonly struct Bfly<N,T> : IUnaryOp<T>
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            public const string Name = "bfly";

            public static Bfly<N,T> Op => default;

            public OpIdentity Id
                => SFx.identity<N,T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a)
                => gbits.bfly<N,T>(a);
        }
    }
}