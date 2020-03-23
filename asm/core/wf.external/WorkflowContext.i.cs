//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;

    /// <summary>
    /// Characterizes a sevice that can participate in workflow execution
    /// </summary>
    public interface IWorkflowService : IAppService
    {
        
    }

    public interface IWorkflowContext : IApiContext
    {
        IAppMsgSink MsgSink {get;}

        IPolyrand Random {get;}
        
    }

    public interface IWorkflowContext<C> : IWorkflowContext, IApiContext<C>
        where C : IApiContext<C>
    {

    }   

    public interface IWorkflowConfig
    {
        
    }

    public interface IWorkflowRunner : IAppEventSource, IWorkflowService
    {
    }

    public interface IWorkflowRunner<C> : IWorkflowRunner
        where C : IWorkflowConfig
    {

        void Run(C config);
    }


    public interface IWorkflowRunner<C,B> : IWorkflowRunner<C>
        where C : IWorkflowConfig
        where B : IWorkflowEventBroker
    {

    }
}