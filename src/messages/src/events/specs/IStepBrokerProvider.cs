//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IStepBrokerProvider : IService
    {
        IStepBroker Broker {get;}
    }
    
    public interface IStepBrokerProvider<R> : IStepBrokerProvider
        where R : IStepBroker
    {
        new R Broker {get;}            

        IStepBroker IStepBrokerProvider.Broker => Broker;

        [MethodImpl(Inline)]
        ref readonly E Raise<E>(in E e)
            where E : IAppEvent
                => ref Broker.Raise(e);
    }
}