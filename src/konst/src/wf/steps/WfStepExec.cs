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

    using api = Flow;

    public struct WfStepExec<H,T> : IWfStepExec<T>
        where H : struct, IWfStepExec<T>, IWfStep<H>
    {
        readonly IWfShell Wf;

        WfStepArgs Args;

        public WfStepId Id {get;}

        H Step;

        [MethodImpl(Inline)]
        public void Configure(WfStepArgs args)
        {
            Args = args;
        }

        [MethodImpl(Inline)]
        public WfStepExec(IWfShell wf, WfStepId id)
        {
            Id = id;
            Wf = wf;
            Args = WfStepArgs.Empty;
            Step = default;
        }

        public Outcome<T> Try(IWfShell wf)
        {
            try
            {
                return Run(wf);
            }
            catch(Exception e)
            {
                return failure<T>(e);
            }
        }

        public Outcome<T> Try()
        {
            try
            {
                return Run();
            }
            catch(Exception e)
            {
                return failure<T>(e);
            }
        }

        [MethodImpl(Inline)]
        public T Run()
            => Step.Run(Wf, Args);

        [MethodImpl(Inline)]
        public T Run(IWfShell wf)
            => Step.Run(wf);
    }
}