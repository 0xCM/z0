//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IDataBroker
    {
    
    }

    public interface IDataBroker<K,T> : IDataBroker
        where K : unmanaged, Enum
    {
        ref readonly DataHandler<T> Get(K key);

        ref DataHandler<T> Set(K key, in DataHandler<T> handler);

        void Relay(K key, T value);

        ref DataHandler<T> this[K key] {get;}
    }
}