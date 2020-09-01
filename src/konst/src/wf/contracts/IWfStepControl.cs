//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IWfStepControl
    {
        void Run();

        WfStepId StepId {get;}
    }

    public interface IWfStepControl<C> : IWfStepControl, IWfStep<C>
        where C : struct, IWfStep<C>
    {

    }
}