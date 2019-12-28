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
        public readonly struct Dec128<T> : IVUnaryOp128D<T>
            where T : unmanaged
        {
            public static Dec128<T> Op => default;

            public const string Name = "vdec";

            public string Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) => ginx.vdec(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gmath.dec(a);
        }

        public readonly struct Dec256<T> : IVUnaryOp256D<T>
            where T : unmanaged
        {
            public static Dec256<T> Op => default;

            public const string Name = "vdec";

            public string Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x) => ginx.vdec(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gmath.dec(a);
        }

    }

}