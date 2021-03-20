//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;

    partial class BC
    {
        [Closures(UInt16x32x64k)]
        public readonly struct ByteSwap<T> : IUnaryOp<T>
            where T : unmanaged
        {
            public static ByteSwap<T> Op => default;

            public const string Name = "byteswap";

            public OpIdentity Id
                => SFx.identity<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a)
                => gbits.byteswap(a);
        }
    }
}