//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed; using static Memories;

    partial class VSvcHosts
    {
        public readonly struct ByteSwap128<T> : ISVUnaryOp128DApi<T>
            where T : unmanaged
        {
            public const string Name = "vbyteswap";

            public Vec128Kind<T> VKind => default;

            public static ByteSwap128<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) => gvec.vbyteswap(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gbits.byteswap(a);
        }

        public readonly struct ByteSwap256<T> : ISVUnaryOp256DApi<T>
            where T : unmanaged
        {
            public const string Name = "vbyteswap";

            public Vec256Kind<T> VKind => default;

            public static ByteSwap256<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x) => gvec.vbyteswap(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gbits.byteswap(a);
        }

    }
}