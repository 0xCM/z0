//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static root;

    public interface IWorkflowEventBroker :  IAppEventRelay
    {
        StepStart<T> StepStarted<T>() => StepStart<T>.Empty;

        StepEnd<T> StepEnded<T>() => StepEnd<T>.Empty;

        WorkflowError Error => WorkflowError.Empty;
    }
}