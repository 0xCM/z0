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
        public readonly struct Nonz128<T> : IVUnaryPred128D<T>
            where T : unmanaged
        {
            public static Nonz128<T> Op => default;

            public string Moniker => moniker<N128,T>("vnonz");

            [MethodImpl(Inline)]
            public bit Invoke(Vector128<T> x) => ginx.vnonz(x);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a) => gmath.nonz(a);
        }

        public readonly struct Nonz256<T> : IVUnaryPred256D<T>
            where T : unmanaged
        {
            public static Nonz256<T> Op => default;

            public string Moniker => moniker<N256,T>("vnonz");

            [MethodImpl(Inline)]
            public bit Invoke(Vector256<T> x) => ginx.vnonz(x);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a) => gmath.nonz(a);
        }
    }
}