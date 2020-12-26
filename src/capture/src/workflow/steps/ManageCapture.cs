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

    [WfHost]
    public sealed class ManageCapture : WfHost<ManageCapture>
    {
        IAsmContext Asm;

        public static WfHost create(IAsmContext asm)
        {
            var host = create();
            host.Asm = asm;
            return host;
        }

        protected override void Execute(IWfShell wf)
        {
            using var step = new ManageCaptureStep(wf, this, Asm);
            step.Run();
        }
    }

    public struct ManageCaptureStep : IManageCapture
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        public IWfCaptureBroker Broker {get;}

        public IWfEventSink Sink {get;}

        readonly IAppContext App;

        readonly PartId[] Parts;

        public ManageCaptureStep(IWfShell wf, WfHost host, IAsmContext asm)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            App = asm.ContextRoot;
            Sink = Wf.WfSink;
            Parts = Wf.Api.PartIdentities;
            //Broker = state.CaptureBroker;
            Broker = AsmWorkflows.broker(wf);
            Asm = asm;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        void RunPrimary()
        {
            using var flow = Wf.Running(nameof(PartCaptureService));
            using var step = PartCaptureService.create(Wf, Asm);
            step.Run();
        }

        void RunImm()
        {
            using var flow = Wf.Running(nameof(EmitImmClosures));
            using var step = new EmitImmClosuresStep(Wf, new EmitImmClosures(), Asm, Asm.Formatter, Asm.RoutineDecoder, Wf.Db().CaptureRoot());
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