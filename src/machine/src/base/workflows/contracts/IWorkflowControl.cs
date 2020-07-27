//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IWorkflowControl : IWorkflowActor
    {

    }
    
    public interface IWorkflowControl<F> : IWorkflowControl, IWorkflowActor<F>
        where F : struct, IWorkflowControl<F>
    {

    }
}