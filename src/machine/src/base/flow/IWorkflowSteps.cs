//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IWorkflowSteps
    {


    }

    public interface IWorkflowSteps<S> : IWorkflowSteps
        where S : struct, IWorkflowSteps
    {

        
    }    
}