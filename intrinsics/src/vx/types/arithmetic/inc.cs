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
        public readonly struct Inc128<T> : IVUnaryOp128D<T>
            where T : unmanaged
        {
            public static Inc128<T> Op => default;

            public const string Name = "vinc";

            public Moniker Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) => ginx.vinc(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gmath.inc(a);
        }

        public readonly struct Inc256<T> : IVUnaryOp256D<T>
            where T : unmanaged
        {
            public static Inc256<T> Op => default;

            public const string Name = "vinc";

            public Moniker Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x)
                => ginx.vinc(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gmath.inc(a);
        }            
    }
}