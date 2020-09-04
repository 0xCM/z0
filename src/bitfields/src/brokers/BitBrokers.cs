//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct BitBrokers
    {
        [MethodImpl(Inline)]
        public static BitBroker<K,T> broker64<K,T>(K kind = default, T rep = default)
            where K : unmanaged, Enum
                => new BitBroker<K,T>(kind);

        [MethodImpl(Inline)]
        public static BitBroker<K,T> broker64<K,T>(WfDataHandler<T>[] buffer, K kind = default)
            where K : unmanaged, Enum
                => new BitBroker<K,T>(kind, buffer);
    }
}