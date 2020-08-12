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
    public readonly struct DataBrokers
    {        
        [MethodImpl(Inline)]
        public static BitBroker<K,T> broker64<K,T>(K kind = default, T rep = default)        
            where K : unmanaged, Enum
                => new BitBroker<K,T>(kind);        

        [MethodImpl(Inline)]
        public static BitBroker<K,T> broker64<K,T>(DataHandler<T>[] buffer, K kind = default)        
            where K : unmanaged, Enum
                => new BitBroker<K,T>(kind, buffer);

        [MethodImpl(Inline)]
        public static DataBroker<K,T> broker<K,T>(int capacity, IndexFunction<K> @if = null)
            where K : unmanaged, Enum
                => new DataBroker<K,T>(capacity, @if ?? Enums.e32i);
    }
}