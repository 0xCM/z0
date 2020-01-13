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

    partial class VXTypes
    {
        public readonly struct TestZ128<T> : IVBinPred128D<T>
            where T : unmanaged
        {
            public static TestZ128<T> Op => default;

            public Moniker Moniker => moniker<N128,T>("vtestz");

            [MethodImpl(Inline)]
            public bit Invoke(Vector128<T> x,Vector128<T> y) => ginx.vtestz(x,y);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a, T b) => default;
        }

        public readonly struct TestZ256<T> : IVBinPred256<T>
            where T : unmanaged
        {
            public static TestZ256<T> Op => default;

            public Moniker Moniker => moniker<N256,T>("vtestz");

            [MethodImpl(Inline)]
            public bit Invoke(Vector256<T> x,Vector256<T> y) => ginx.vtestz(x,y);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a, T b) => default;
        }
   }
}