//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IWorkflowStep
    {
        
    }
    
    public interface IWorkflowStep<F> : IWorkflowStep
        where F : IWorkflowStep<F>
    {

    }
}