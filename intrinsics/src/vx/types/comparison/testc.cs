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
        public readonly struct TestC128<T> : IVBinPred128D<T>
            where T : unmanaged
        {
            public static TestC128<T> Op => default;

            public const string Name = "vtestc";
             
            public string Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(Vector128<T> x, Vector128<T> y) => ginx.vtestc(x,y);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a, T b) => default;
        }

        public readonly struct TestC256<T> : IVBinPred256D<T>
            where T : unmanaged
        {
            public static TestC256<T> Op => default;

            public const string Name = "vtestc";

            public string Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(Vector256<T> x, Vector256<T> y) => ginx.vtestc(x,y);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a, T b) => default;
        }

    }
}