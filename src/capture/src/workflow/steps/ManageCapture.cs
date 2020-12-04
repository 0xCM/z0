//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Z0.Asm;

    using static z;

    [WfHost]
    public sealed class ManageCapture : WfHost<ManageCapture>
    {
        WfCaptureState State;

        public static WfHost create(WfCaptureState state)
        {
            var host = create();
            host.State = state;
            return host;
        }

        protected override void Execute(IWfShell wf)
        {
            using var step = new ManageCaptureStep(State,this);
            step.Run();
        }
    }

    public struct ManageCaptureStep : IManageCapture
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly WfCaptureState State;

        readonly IAsmWf Asm;

        public IWfCaptureBroker Broker {get;}

        public IWfEventSink Sink {get;}

        readonly IAppContext App;

        readonly PartId[] Parts;

        public ManageCaptureStep(WfCaptureState state, WfHost host)
        {
            Host = host;
            Wf = state.Wf.WithHost(host);
            State = state;
            App = state.Asm.ContextRoot;
            Sink = Wf.WfSink;
            Parts = Wf.Api.PartIdentities;
            Broker = state.CaptureBroker;
            Asm = AsmWorkflows.create(Wf, Host);
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        void RunPrimary()
        {
            using var flow = Wf.Running(nameof(CaptureParts));
            CaptureParts.create().Run(Wf, State);
        }

        void RunImm()
        {
            using var flow = Wf.Running(nameof(EmitImmClosures));
            using var step = new EmitImmClosuresStep(Wf, new EmitImmClosures(), State.Asm, State.Formatter, State.RoutineDecoder, Wf.Db().CaptureRoot());
            step.ClearArchive(Parts);
            step.EmitRefined(Parts);
        }

        void RunEvaluate()
        {
            using var flow = Wf.Running(nameof(Evaluate));
            var evaluate = Evaluate.control(App, Wf.Paths.AppCaptureRoot, Pow2.T14);
            evaluate.Execute();
        }

        void EmitReports()
        {
            using var flow = Wf.Running(MethodInfo.GetCurrentMethod().Name);
            EmitCodeBlockReport.create().Run(Wf);
        }

        public void Run()
        {
            using var flow = Wf.Running();
            RunPrimary();
            RunImm();
            RunEvaluate();
            EmitReports();
        }
    }
}