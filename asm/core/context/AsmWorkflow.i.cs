//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;

    public interface IAsmWorkflowContext : IAsmContext, IRngProvider
    {
    
    
    }   
    
    public interface IAsmWorkflowService : IWorkflowService, IAsmService    
    {
        new IAsmWorkflowContext Context {get;}    

        IAsmContext IContextual<IAsmContext>.Context
            => Context;
    }

    public interface IAsmWorkflow : IAsmWorkflowService
    {
                    
    }


    public interface IAsmWorkflowRunner : IWorkflowRunner, IAsmWorkflowService
    {

    }

    public interface IAsmWorkflowRunner<C> : IAsmWorkflowRunner, IWorkflowRunner<C>
        where C : IWorkflowConfig
    {


    }

    public interface IAsmWorkflowRunner<C,B> : IAsmWorkflowRunner<C>, IWorkflowRunner<C,B>
        where C : IWorkflowConfig
        where B : IWorkflowEventBroker
    {
        
    }    
}