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
        public readonly struct Add128<T> : IVBinOp128D<T>
            where T : unmanaged
        {
            public const string Name = "vadd";

            public static Add128<T> Op => default;
             
            static N128 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => ginx.vadd(x,y);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.add(a,b);
        }

        public readonly struct Add256<T> : IVBinOp256D<T>
            where T : unmanaged
        {
            public const string Name = "vadd";

            public static Add256<T> Op => default;
            
            static N256 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => ginx.vadd(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.add(a,b);
        }
    }
}