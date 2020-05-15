//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface IAsmProcessor<T> : IMachineService, IDataProcessor<T>
    {

    }

    public interface IAsmProcessor<E,T> : IAsmProcessor<T>
        where E : unmanaged, Enum
    {
        IDataBroker<E,T> Broker {get;}

        void Relay(E kind, T data)
            => Broker.Relay(kind,data);
    }
}