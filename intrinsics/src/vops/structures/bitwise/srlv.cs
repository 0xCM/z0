//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class VOpTypes
    {

        public readonly struct Srlv128<T> : IVBinOp128<T>
            where T : unmanaged
        {
            public static Srlv128<T> Op => default;

            public string Moniker => moniker<N128,T>("vsrlv");

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> offsets) => ginx.vsrlv(x,offsets);
            
        }

        public readonly struct Srlv256<T> : IVBinOp256<T>
            where T : unmanaged
        {
            public static Srlv256<T> Op => default;

            public string Moniker => moniker<N256,T>("vsrlv");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> offsets) => ginx.vsrlv(x,offsets);
        }
    }
}