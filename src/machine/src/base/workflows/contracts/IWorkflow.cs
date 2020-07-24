//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IWorkflow : IAppMsgReceiver, IBrokerClient
    {
        
    }

    public interface IWorkflow<F> : IWorkflow
        where F : IWorkflow<F>
    {

    }

    public interface IWorkflow<F,E> : IBrokerClient<E>, IWorkflow
        where F : IWorkflow<F,E>
        where E : IEventBroker
    {

    }
}