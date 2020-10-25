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
    }

    public readonly ref struct CaptureWorkflowMain
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        public WfCaptureState State {get;}


        public CaptureWorkflowMain(WfCaptureState state, WfHost host)
        {
            Host = host;
            State = state;
            Wf = state.Wf.WithHost(host);
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            var flow = Wf.Running();

            Wf.Status(enclose(Wf.Init.PartIdentities));

            try
            {
                using var host = new ManageCaptureStep(State, Wf.Ct);
                host.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran(flow);
        }
    }
}