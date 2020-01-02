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
        public readonly struct NonZ128<T> : IVUnaryPred128D<T>
            where T : unmanaged
        {
            public static NonZ128<T> Op => default;

            public const string Name = "vnonz";

            public string Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(Vector128<T> x) => ginx.vnonz(x);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a) => gmath.nonz(a);
        }

        public readonly struct NonZ256<T> : IVUnaryPred256D<T>
            where T : unmanaged
        {
            public static NonZ256<T> Op => default;

            public const string Name = "vnonz";

            public string Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(Vector256<T> x) => ginx.vnonz(x);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a) => gmath.nonz(a);
        }
    }
}