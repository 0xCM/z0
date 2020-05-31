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

    public interface IDataBroker<E,T> : IDataBroker
        where E : unmanaged, Enum
    {
        ref readonly DataHandler<T> Get(E kind);

        ref DataHandler<T> Set(E kind, in DataHandler<T> handler);

        void Relay(E kind, T data);

        ref DataHandler<T> this[E kind] {get;}
    }
}