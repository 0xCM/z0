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
        public readonly struct ByteSwap128<T> : IVUnaryOp128D<T>
            where T : unmanaged
        {
            public static ByteSwap128<T> Op => default;

            public const string Name = "vbyteswap";

            static N128 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) => ginx.vbyteswap(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gbits.byteswap(a);
        }

        public readonly struct ByteSwap256<T> : IVUnaryOp256D<T>
            where T : unmanaged
        {
            public static ByteSwap256<T> Op => default;

            public const string Name = "vbyteswap";

            static N256 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x) => ginx.vbyteswap(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gbits.byteswap(a);
        }

    }
}