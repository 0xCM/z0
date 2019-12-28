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
        public readonly struct Not128<T> : IVUnaryOp128D<T>
            where T : unmanaged
        {
            public static Not128<T> Op => default;

            public string Moniker => moniker<N128,T>("vnot");

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x)
                => ginx.vnot(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gmath.not(a);
        }

        public readonly struct Not256<T> : IVUnaryOp256D<T>
            where T : unmanaged
        {
            public static Not256<T> Op => default;

            public string Moniker => moniker<N256,T>("vnot");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x)
                => ginx.vnot(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gmath.not(a);
        }

   }

}