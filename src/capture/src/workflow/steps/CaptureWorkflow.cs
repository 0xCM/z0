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
    using static z;

    [WfHost]
    public sealed class CaptureWorkflow : WfHost<CaptureWorkflow>
    {
        public static CaptureWorkflowMain create(WfCaptureState state)
            => new CaptureWorkflowMain(state, new CaptureWorkflow());

        public static CaptureWorkflowMain create(IAsmWf asm)
            => new CaptureWorkflowMain(asm, new CaptureWorkflow());

        protected override void Execute(IWfShell shell)
        {
            throw new NotImplementedException();
        }
    }

    public readonly ref struct CaptureWorkflowMain
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        public WfCaptureState State {get;}

        readonly IAsmWf Asm;

        public CaptureWorkflowMain(IAsmWf asm, WfHost host)
        {
            Host = host;
            Asm = asm;
            Wf = asm.Wf;
            State = default;
            Wf.Created();
        }

        public CaptureWorkflowMain(WfCaptureState state, WfHost host)
        {
            Host = host;
            State = state;
            Wf = state.Wf.WithHost(host);
            Asm = AsmWorkflows.create(Wf);
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            using var flow = Wf.Running();
            Wf.Status(enclose(Wf.Api.PartIdentities));
            ManageCapture.create(State).Run(Wf);
        }
    }
}