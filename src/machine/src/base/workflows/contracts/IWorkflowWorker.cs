//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    public interface IWorkflowWorker : IWorkflowActor
    {
        
    }

    public interface IWorkflowWorker<F> : IWorkflowWorker, IWorkflowActor<F>
        where F : struct, IWorkflowWorker<F>
    {
    }
}