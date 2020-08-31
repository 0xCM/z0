//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static WfCaptureControl;

    using static z;

    public readonly ref struct CaptureControl
    {
        readonly IAsmContext Asm;

        readonly CorrelationToken Ct;

        readonly IWfContext Wf;

        public WfCaptureState State {get;}

        public CaptureControl(WfCaptureState state)
        {
            State = state;
            Wf = state.Wf;
            Ct = state.Ct;
            Asm = AsmWfBuilder.asm(state.App);
            Wf.Created(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId, delimit(Wf.Config.Parts));

            try
            {
                using var host = new ManageCapture(State, Ct);
                host.Run();
            }
            catch(Exception e)
            {
                State.Error(ActorName, e, Ct);
            }

            Wf.Ran(StepId);
        }

        public void Dispose()
        {
            Wf.Finished(StepId);
        }
    }
}