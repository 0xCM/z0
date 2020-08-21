//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct ConfiguredStep<T>  : IWfStep<T>
        where  T : struct, IWfStep<T>
    {
        readonly T Step;

        WfStepArgs Args;

        [MethodImpl(Inline)]
        public ConfiguredStep(in T step, WfStepArgs args)
        {
            Step = step;
            Args = args;
        }

        [MethodImpl(Inline)]
        public void Configure(params WfStepArg[] args)
        {
            Args = args;
            Step.Configure(Args) ;
        }

        public WfStepId StepId
            => Step.StepId;

        [MethodImpl(Inline)]
        public void Run()
            => Step.Run();
    }
}