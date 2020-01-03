//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    partial class BCTypes
    {
        public readonly struct Bfly<N,T> : INaturalUnaryOp<N,T>
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            public const string Name = "bfly";

            public static Bfly<N,T> Op => default;

            public string Moniker => moniker<N,T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a) => gbits.bfly<N,T>(a);
        }


    }

}