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
        public readonly struct Xor128<T> : IVBinOp128D<T>
            where T : unmanaged
        {
            public static Xor128<T> Op => default;

            public const string Name = "vxor";

            public string Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => ginx.vxor(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.xor(a,b);

        }

        public readonly struct Xor256<T> : IVBinOp256D<T>
            where T : unmanaged
        {
            public static Xor256<T> Op => default;

            public const string Name = "vxor";

            public string Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => ginx.vxor(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.xor(a,b);

        }
   }
}