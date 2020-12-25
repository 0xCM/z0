//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static z;

    [WfHost]
    public sealed class CaptureWorkflow : WfHost<CaptureWorkflow>
    {
        static IWfShell describe(IWfShell wf)
        {
            iter(wf.Settings, s => wf.Status(string.Format("{0}:{1}", s.Name, s.Value )));
            return wf;
        }

        static IWfShell Configure(IWfShell wf)
            => describe(wf.WithRandom(Rng.@default())
                 .WithHost(WfShell.host(typeof(CaptureWorkflow)))
                 .WithVerbosity(LogLevel.Babble));

        public static void run(WfCaptureState state)
        {
            using var control = CaptureWorkflow.create(state);
            control.Run();
        }

        public static void run(IWfShell wf)
        {
            var app = Apps.context(wf);
            var asm = new AsmContext(app, wf);
            var state = new WfCaptureState(wf, asm);
            run(state);
        }

        public static void run(string[] args)
        {
            using var wf = Configure(WfShell.create(args));
            run(wf);
        }

        public static CaptureWorkflowMain create(WfCaptureState state)
            => new CaptureWorkflowMain(state, new CaptureWorkflow());

        public static CaptureWorkflowMain create(IWfShell wf, IAsmContext asm)
            => new CaptureWorkflowMain(wf, asm, new CaptureWorkflow());

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

        readonly IAsmContext Asm;

        public CaptureWorkflowMain(IWfShell wf, IAsmContext asm, WfHost host)
        {
            Host = host;
            Asm = asm;
            Wf = wf;
            State = default;
            Wf.Created();
        }

        public CaptureWorkflowMain(WfCaptureState state, WfHost host)
        {
            Host = host;
            State = state;
            Wf = state.Wf.WithHost(host);
            Asm = state.Asm;
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