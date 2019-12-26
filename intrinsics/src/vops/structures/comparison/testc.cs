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
        public readonly struct Testc128<T> : IVBinPred128D<T>
            where T : unmanaged
        {
            public static Testc128<T> Op => default;

            public string Moniker => moniker<N128,T>("vtestc");

            [MethodImpl(Inline)]
            public bit Invoke(Vector128<T> x,Vector128<T> y) => ginx.vtestc(x,y);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a, T b) => default;
        }

        public readonly struct Testc256<T> : IVBinPred256D<T>
            where T : unmanaged
        {
            public static Testc256<T> Op => default;

            public string Moniker => moniker<N256,T>("vtestc");

            [MethodImpl(Inline)]
            public bit Invoke(Vector256<T> x,Vector256<T> y)
                => ginx.vtestc(x,y);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a, T b) => default;
        }

    }
}