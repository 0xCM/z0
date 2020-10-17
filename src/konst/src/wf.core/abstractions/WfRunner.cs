//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public abstract class WfRunner<H,A> : IWfRunner<H,A>
        where H : WfRunner<H,A>
    {
        readonly IWfShell Wf;

        readonly WfStepId Step;

        [MethodImpl(Inline)]
        protected WfRunner(IWfShell wf)
        {
            Wf = wf;
            Wf.Created(Step);
        }

        protected abstract void Execute(H args);

        [MethodImpl(Inline)]
        public void Run(H args)
        {
            Wf.Running(Step, args);

            try
            {
                Execute(args);
            }
            catch(Exception e)
            {
                Wf.Error(e, Wf.Ct);
            }

            Wf.Ran(Step, args);
        }


        public void Dispose()
        {
            Wf.Disposed(Step);
        }
    }
}