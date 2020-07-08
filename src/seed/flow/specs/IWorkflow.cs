//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IWorkflow : IAppMsgReceiver, IBrokerClient
    {
        
    }

    public interface IWorkflow<E> : IWorkflow, IBrokerClient<E>
        where E : IEventBroker
    {

    }

    public interface IWorkflow<F,E> : IWorkflow<E>
        where F : IWorkflow<F,E>
        where E : IEventBroker
    {

    }
}