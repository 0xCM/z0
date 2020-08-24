//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static CaptureClientStep;

    public struct CaptureClient : IWfCaptureClient
    {
        readonly WfCaptureState Wf;

        readonly CorrelationToken Ct;

        public IWfCaptureBroker Broker {get;}

        public IMultiSink Sink {get;}

        readonly IImmEmitter ImmEmitter;

        public CaptureClient(WfCaptureState wf, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Sink = Wf.Wf.WfSink;
            Broker = wf.CaptureBroker;
            ImmEmitter = Wf.Services.ImmEmitter(Sink, Wf.Asm.Api, Wf.Formatter, Wf.RoutineDecoder, Wf.Config, Ct);
            Wf.Created(StepName, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(nameof(CaptureClient), Ct);
        }

        public void Run()
        {
            (this as IWfCaptureClient).Connect();

            var parts = Wf.Config.Parts.Length == 0 ? Wf.Root.PartIdentities : Wf.Config.Parts;
            Wf.Raise(new CapturingParts(StepName, parts, Ct));

            using var manage = new ManagePartCapture(Wf, Ct);
            manage.Consolidate();

            ImmEmitter.ClearArchive(parts);
            ImmEmitter.EmitRefined(parts);

            Wf.Running(nameof(Evaluate), Ct);
            var eval = Evaluate.control(Wf.Root, Wf.Root.Random, Wf.Root.AppPaths.AppCaptureRoot, Pow2.T14);
            eval.Execute();
            Wf.Ran(nameof(Evaluate), Ct);

            Wf.Ran(StepName, Ct);
        }

        public void OnEvent(FunctionsDecoded e)
        {
            Sink.Deposit(e);

            if(Wf.Settings.CollectAsmStats)
                CollectAsmStats(e.Host, e.Functions);
        }

        public void OnEvent(HexCodeSaved e)
        {
            Sink.Deposit(e);

            if(Wf.Settings.MatchEmissions)
            {
                var step = new MatchEmissions(Wf.CWf, Ct);
                step.Run(e.Host, e.Code, e.Target);
            }
        }

        public void OnEvent(MembersLocated e)
        {
            Sink.Deposit(e);

            if(Wf.Settings.DuplicateCheck)
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
                Wf.Raise(new WfWarn<string>(StepName, $"Duplicate key {key}", Ct));
        }
    }
}