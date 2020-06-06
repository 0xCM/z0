//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
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

    public interface IDataBroker<K,C,T> : IDataBroker
        where K : unmanaged, Enum
    {
        ref readonly DataHandler<C,T> Get(K key);

        ref DataHandler<C,T> Set(K key, in DataHandler<C,T> handler);

        void Relay(K key, C context, T value);

        ref DataHandler<C,T> this[K key] {get;}
    }    
}