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
        public readonly struct Or128<T> : IVBinOp128D<T>
            where T : unmanaged
        {
            public static Or128<T> Op => default;

            public const string Name = "vor";

            public Moniker Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => ginx.vor(x,y);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.or(a,b);
        }

        public readonly struct Or256<T> : IVBinOp256D<T>
            where T : unmanaged
        {
            public static Or256<T> Op => default;

            public const string Name = "vor";

            public Moniker Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => ginx.vor(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.or(a,b);
        }
    }
}