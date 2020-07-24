//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IWorkflowStep
    {
        void Run();        
    }
    
    public interface IWorkflowStep<S> : IWorkflowStep
        where S : struct, IWorkflowStep<S>
    {

    }
}