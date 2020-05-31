//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;    

    [ApiHost]
    public readonly struct DataBrokers : IApiHost<DataBrokers>
    {        
        [MethodImpl(Inline)]
        public static DataBroker64<K,T> broker64<K,T>(K kind = default, T rep = default)        
            where K : unmanaged, Enum
                => new DataBroker64<K,T>(kind);        

        [MethodImpl(Inline)]
        public static DataBroker64<K,T> broker64<K,T>(DataHandler<T>[] buffer, K kind = default)        
            where K : unmanaged, Enum
                => new DataBroker64<K,T>(kind, buffer);

        [MethodImpl(Inline)]
        public static DataBroker<K,T> broker<K,T>(int capacity, IndexFunction<K> @if = null)
            where K : unmanaged, Enum
                => new DataBroker<K,T>(capacity, @if ?? Enums.i32);
    }
}