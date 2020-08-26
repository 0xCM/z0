//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IWfDataBroker<K,T>
        where K : unmanaged, Enum
    {
        ref readonly WfDataHandler<T> Get(K key);

        ref WfDataHandler<T> Set(K key, in WfDataHandler<T> handler);

        void Relay(K key, T value);

        ref WfDataHandler<T> this[K key] {get;}
    }

    public interface IWfDataBroker<K,C,T>
        where K : unmanaged, Enum
    {
        ref readonly DataHandler<C,T> Get(K key);

        ref DataHandler<C,T> Set(K key, in DataHandler<C,T> handler);

        void Relay(K key, C context, T value);

        ref DataHandler<C,T> this[K key] {get;}
    }
}