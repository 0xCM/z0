//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Core;

    partial class BitCoreServices
    {
        public readonly struct ByteSwap<T> : ISUnaryOpApi<T>
            where T : unmanaged        
        {
            public static ByteSwap<T> Op => default;

            public const string Name = "byteswap";

            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a) => gbits.byteswap(a);
        }
    }
}