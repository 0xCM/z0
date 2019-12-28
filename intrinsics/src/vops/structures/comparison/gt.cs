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
        public readonly struct Gt128<T> : IVBinOp128D<T>
            where T : unmanaged
        {
            public static Gt128<T> Op => default;

            public string Moniker => moniker<N128,T>("vgt");

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => ginx.vgt(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b)
                => gmath.mul(convert<T>((uint)gmath.gt(a,b)),gmath.ones<T>());

        }

        public readonly struct Gt256<T> : IVBinOp256D<T>
            where T : unmanaged
        {
            public static Gt256<T> Op => default;

            public string Moniker => moniker<N256,T>("vgt");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => ginx.vgt(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b)
                => gmath.mul(convert<T>((uint)gmath.gt(a,b)), gmath.ones<T>());
        } 
    }
}