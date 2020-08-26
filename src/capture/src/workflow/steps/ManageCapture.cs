//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static ManageCaptureStep;

    public struct ManageCapture : IManageCapture
    {
        readonly WfCaptureState State;

        readonly IWfContext Wf;

        readonly CorrelationToken Ct;

        public IWfCaptureBroker Broker {get;}

        public IMultiSink Sink {get;}

        readonly IImmEmitter ImmEmitter;

        public ManageCapture(WfCaptureState state, CorrelationToken ct)
        {
            State = state;
            Wf = state.Wf;
            Ct = ct;
            Sink = Wf.WfSink;
            Broker = state.CaptureBroker;
            ImmEmitter = State.Services.ImmEmitter(Sink, State.Asm.Api, State.Formatter, State.RoutineDecoder, State.Config, Ct);
            Wf.Created(StepName, Ct);
        }

        public void Dispose()
        {
            State.Finished(nameof(ManageCapture), Ct);
        }

        public void Run()
        {
            (this as IManageCapture).Connect();

            Wf.Raise(new CapturingParts(StepName, State.Parts, Ct));

            using var manage = new ManagePartCapture(State, Ct);
            manage.Consolidate();

            ImmEmitter.ClearArchive(State.Parts);
            ImmEmitter.EmitRefined(State.Parts);

            Wf.Running(nameof(Evaluate), Ct);
            var eval = Evaluate.control(State.Root, State.Root.Random, Wf.AppPaths.AppCaptureRoot, Pow2.T14);
            eval.Execute();
            State.Ran(nameof(Evaluate), Ct);

            Wf.Ran(StepName, Ct);
        }

        public void OnEvent(FunctionsDecoded e)
        {
            Sink.Deposit(e);

            if(State.Settings.CollectAsmStats)
                CollectAsmStats(e.Host, e.Functions);
        }

        public void OnEvent(HexCodeSaved e)
        {
            Sink.Deposit(e);

            if(State.Settings.MatchEmissions)
            {
                var step = new MatchEmissions(State.CWf, Ct);
                step.Run(e.Host, e.Code, e.Target);
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

           Wf.Raise(new CountedInstructions(StepName, host, count, Ct));
        }

        void CheckDuplicates(ApiHostUri host, ReadOnlySpan<ApiMember> src)
        {
            var index = ApiMemberOps.index(src);
            foreach(var key in index.DuplicateKeys)
                State.Raise(new WfWarn<string>(StepName, $"Duplicate key {key}", Ct));
        }
    }
}