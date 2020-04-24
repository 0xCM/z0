//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed; 

    partial class VSvcHosts
    {
        public readonly struct ByteSwap128<T> : ISVUnaryOp128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) => gvec.vbyteswap(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gbits.byteswap(a);
        }

        public readonly struct ByteSwap256<T> : ISVUnaryOp256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x) => gvec.vbyteswap(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gbits.byteswap(a);
        }
    }
}