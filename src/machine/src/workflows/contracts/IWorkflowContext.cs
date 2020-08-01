//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IWorkflowContext
    {
        IAppContext ContextRoot {get;}
    }

    public interface IWorkflowContext<T> : IWorkflowContext
    {
        T ContextData {get;}
    }    
}