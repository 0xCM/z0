//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial class VServices
    {
        public readonly struct ByteSwap128<T> : IUnaryOp128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) => gvec.vbyteswap(x);

            [MethodImpl(Inline)]
            public T Invoke(T a) => gbits.byteswap(a);
        }

        public readonly struct ByteSwap256<T> : IUnaryOp256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x) => gvec.vbyteswap(x);

            [MethodImpl(Inline)]
            public T Invoke(T a) => gbits.byteswap(a);
        }
    }
}