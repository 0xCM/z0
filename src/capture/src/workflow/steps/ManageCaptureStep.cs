//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    public struct ManageCaptureStep : IManageCapture
    {
        readonly WfCaptureState State;

        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        public IWfCaptureBroker Broker {get;}

        public IWfEventSink Sink {get;}

        readonly IAppContext App;

        readonly PartId[] Parts;

        readonly ManageCapture Step;

        WfStepId StepId => Step.Id;

        public ManageCaptureStep(WfCaptureState state, CorrelationToken ct)
        {
            State = state;
            App = state.Asm.ContextRoot;
            Wf = state.Wf;
            Ct = ct;
            Sink = Wf.WfSink;
            Parts = Wf.Api.PartIdentities;
            Broker = state.CaptureBroker;
            Step = new ManageCapture();
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        public void Run()
        {
            (this as IManageCapture).Connect();

            Wf.Running(StepId);

            {
                Wf.Raise(new CapturingParts(Step.Name, State.Parts, Ct));
                using var manage = new CapturePartsStep(State, new CaptureParts());
                manage.Run();
            }

            {
                using var step = new SpecializeImmStep(Wf, State.Asm, State.Formatter, State.RoutineDecoder, Wf.Init.TargetArchive.Root);
                step.ClearArchive(Parts);
                step.EmitRefined(Parts);
            }

            {
                Wf.Running(EvaluateStep.StepId);
                var evaluate = Evaluate.control(App, Wf.Paths.AppCaptureRoot, Pow2.T14);
                evaluate.Execute();
                Wf.Ran(EvaluateStep.StepId);
            }

            EmitCodeBlockReport.create().Run(Wf);

            Wf.Ran(StepId);
        }

        public void OnEvent(MembersLocated e)
        {
            Sink.Deposit(e);

            CheckDuplicates(e.Host, e.Members);
        }

        void CheckDuplicates(ApiHostUri host, ReadOnlySpan<ApiMember> src)
        {
            var index = ApiIdentify.index(src);
            foreach(var key in index.DuplicateKeys)
                Wf.Warn(StepId, $"Duplicate key {key}");
        }
    }
}