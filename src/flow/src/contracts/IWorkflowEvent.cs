//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IWorkflowEvent : IAppEvent
    {
        
    }

    public interface IWorkflowEvent<F> : IWorkflowEvent, IAppEvent<F>
        where F : struct, IWorkflowEvent<F>
    {

    }
}