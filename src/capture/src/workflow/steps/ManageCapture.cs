//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    public struct ManageCapture : IManageCapture
    {
        readonly WfCaptureState State;

        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        public IWfCaptureBroker Broker {get;}

        public IWfEventSink Sink {get;}

        readonly IAppContext App;

        readonly PartId[] Parts;

        readonly ManageCaptureStep Step;

        WfStepId StepId => Step.Id;

        public ManageCapture(WfCaptureState state, CorrelationToken ct)
        {
            State = state;
            App = state.Asm.ContextRoot;
            Wf = state.Wf;
            Ct = ct;
            Sink = Wf.WfSink;
            Parts = Wf.Api.PartIdentities;
            Broker = state.CaptureBroker;
            Step = new ManageCaptureStep();
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
                using var manage = new CaptureParts(State);
                manage.Run();
            }

            {
                using var step = new EmitImmSpecials(Wf, State.Asm, State.Formatter, State.RoutineDecoder, Wf.Init.TargetArchive.Root);
                step.ClearArchive(Parts);
                step.EmitRefined(Parts);
            }

            {
                Wf.Running(EvaluateStep.StepId);
                var evaluate = Evaluate.control(App, Wf.Paths.AppCaptureRoot, Pow2.T14);
                evaluate.Execute();
                Wf.Ran(EvaluateStep.StepId);
            }

            Wf.Ran(StepId);
        }

        public void OnEvent(FunctionsDecoded e)
        {
            Sink.Deposit(e);

            if(State.Settings.CollectAsmStats)
                CollectAsmStats(e.Host, e.Functions);
        }

        public void OnEvent(X86UriHexSaved e)
        {
            Sink.Deposit(e);

            if(State.Settings.MatchEmissions)
            {
                using var step = new MatchEmissions(Wf);
                step.Run(e.Host, e.ApiHex, e.Target);
                Broker.Raise(step.Event);
            }
        }

        public void OnEvent(MembersLocated e)
        {
            Sink.Deposit(e);

            if(State.Settings.DuplicateCheck)
                CheckDuplicates(e.Host, e.Members);
        }

        void CollectAsmStats(ApiHostUri host, ReadOnlySpan<AsmRoutine> functions)
        {
            var count = 0u;
            for(var i = 0u; i<functions.Length; i++)
                count += (uint)z.skip(functions,i).InstructionCount;

           Wf.Raise(new CountedInstructions(Step.Name, host, count, Ct));
        }

        void CheckDuplicates(ApiHostUri host, ReadOnlySpan<ApiMember> src)
        {
            var index = ApiMemberOps.index(src);
            foreach(var key in index.DuplicateKeys)
                Wf.Warn(StepId, $"Duplicate key {key}");
        }
    }
}