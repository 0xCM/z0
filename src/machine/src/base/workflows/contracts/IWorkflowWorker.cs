//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public interface IWorkflowWorker<F> : IWorkflowActor, IWorkflowActor<F>
        where F : struct, IWorkflowWorker<F>
    {
    }
}