//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IWfDataBroker<K,T>
        where K : unmanaged
    {
        ref readonly DataHandler<T> Get(K key);

        void Relay(K key, T value);

        ref DataHandler<T> this[K key] {get;}
    }

    public interface IWfDataBroker<K,C,T>
        where K : unmanaged
    {
        ref readonly DataHandler<C,T> Get(K key);

        void Relay(K key, C context, T value);

        ref DataHandler<C,T> this[K key] {get;}
    }
}