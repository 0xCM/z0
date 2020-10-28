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
            State = state;
            App = state.Asm.ContextRoot;
            Wf = state.Wf.WithHost(host);
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

        public void Run()
        {
            var flow = Wf.Running();

            CaptureParts.create().Run(Wf, State);

            {
                using var step = new SpecializeImmStep(Wf, new SpecializeImm(), State.Asm, State.Formatter, State.RoutineDecoder, Wf.Db().CaptureRoot());
                step.ClearArchive(Parts);
                step.EmitRefined(Parts);
            }

            {
                var inner = Wf.Running();
                var evaluate = Evaluate.control(App, Wf.Paths.AppCaptureRoot, Pow2.T14);
                evaluate.Execute();
                Wf.Ran(inner);
            }

            EmitCodeBlockReport.create().Run(Wf);

            Wf.Ran(flow);
        }
    }
}