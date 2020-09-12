//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IAsmDataProcessor<T> : IWfDataProcessor<T>
    {
        void Process(T src);
    }

    public interface IAsmDataProcessor<E,T> : IAsmDataProcessor<T>
        where E : unmanaged, Enum
    {
        IWfDataBroker<E,T> Broker {get;}

        void Relay(E kind, T data)
            => Broker.Relay(kind,data);
    }
}