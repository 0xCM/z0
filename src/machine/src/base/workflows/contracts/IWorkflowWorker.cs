//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IWorkflowWorker : IWorkflowActor
    {
        
    }

    public interface IWorkflowWorker<F> : IWorkflowWorker, IWorkflowActor<F>
        where F : struct, IWorkflowWorker<F>
    {
    }
}