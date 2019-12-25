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
        public readonly struct VabsOp128<T> : IVUnaryOp128<T>
            where T : unmanaged
        {
            public static VabsOp128<T> Op => default;

            public const string Name = "vabs";
             

            public string Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x)
                => ginx.vabs(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a)
                => gmath.abs(a);
        }

        public readonly struct VabsOp256<T> : IVUnaryOp256<T>
            where T : unmanaged
        {
            public static VabsOp256<T> Op => default;

            public const string Name = "vabs";

            public string Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x)
                => ginx.vabs(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a)
                => gmath.abs(a);
        }
    }
}