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

    partial class VXTypes
    {
        public readonly struct Eq128<T> : IVBinOp128D<T>
            where T : unmanaged
        {
            public static Eq128<T> Op => default;

            public const string Name = "veq";


            public string Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => ginx.veq(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.eqz(a,b);
        }

        public readonly struct Eq256<T> : IVBinOp256D<T>
            where T : unmanaged
        {
            public static Eq256<T> Op => default;

            public const string Name = "veq";

            public string Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => ginx.veq(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.eqz(a,b);
        }

    }
}